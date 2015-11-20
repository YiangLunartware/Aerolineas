using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AirlineServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioMigrantes" in both code and config file together.
    public class ServicioMigrantes : IServicioMigrantes
    {
        public List<PaisBE> ListaPaises()
        {
            AerolineaEntities MiAerolinea = new AerolineaEntities();
            List<PaisBE> objListaPais = new List<PaisBE>();

            try
            {
                var query = from objPais in MiAerolinea.PAIS
                            orderby objPais.NOMBRE_PAIS
                            select new { Codigo = objPais.COD_PAIS, Nombre = objPais.NOMBRE_PAIS };

                foreach (var resultado in query)
                {
                    PaisBE objPaisBE = new PaisBE();

                    objPaisBE.CodPais = resultado.Codigo;
                    objPaisBE.NomPais = resultado.Nombre;

                    objListaPais.Add(objPaisBE);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return objListaPais;
        }

        public PaisBE ConsultaMaximoMigrantesNacionalidad(string codPaisNacimiento)
        {
            //Pais al han migrado más las personas de cierto pais

            AerolineaEntities MiAerolinea = new AerolineaEntities();
            PaisBE objPaisBE = new PaisBE();

            try
            {
                var query = MiAerolinea.usp_ConsultaMaximoMigrantesNacionalidad(codPaisNacimiento).FirstOrDefault();

                objPaisBE.CodPais = query.COD_PAIS_DESTINO;
                objPaisBE.NomPais = query.NOMBRE_PAIS_DESTINO;
                objPaisBE.Idioma = query.IDIOMA_PAIS_DESTINO;
                objPaisBE.Moneda = query.MONEDA_PAIS_DESTINO;
                objPaisBE.CantVuelos = Convert.ToInt32(query.CANTIDAD_VUELOS);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return objPaisBE;
        }



        public List<MigranteBE> ListaMigrantesInternacionales(string codPaisNacimiento, System.DateTime fecIni, System.DateTime fecFin)
        {
            AerolineaEntities MiAerolinea = new AerolineaEntities();
            List<MigranteBE> objListaBE = new List<MigranteBE>();

            //SI es internacional devuelve datos con paises
            //SI es nacional devuelve datos con lugares

            try
            {
                var query = (from tbPasajero in MiAerolinea.PASAJERO
                             join tbReservacion in MiAerolinea.RESERVACION
                                        on tbPasajero.COD_PASAJERO equals tbReservacion.COD_PASAJERO
                             join tbVuelo in MiAerolinea.VUELO
                                        on tbReservacion.COD_VUELO equals tbVuelo.COD_VUELO
                             join tbRuta in MiAerolinea.RUTA
                                        on tbVuelo.COD_RUTA equals tbRuta.COD_RUTA
                             join tbLugar in MiAerolinea.LUGAR
                                        on tbRuta.COD_DESTINO equals tbLugar.COD_LUGAR
                             join tbPais in MiAerolinea.PAIS
                                        on tbLugar.COD_PAIS equals tbPais.COD_PAIS
                             where tbPasajero.COD_PAIS == codPaisNacimiento &&
                                    tbRuta.TIPO_RUTA == "INTERNACIONAL" &&
                             tbVuelo.FECHA_LLEGADA >= fecIni &&
                             tbVuelo.FECHA_LLEGADA <= fecFin

                             select new
                             {
                                 Codigo = tbPasajero.COD_PASAJERO,
                                 Nombre = tbPasajero.NOMBRE_PASAJERO,
                                 Apellido = tbPasajero.APELLIDO_PASAJERO,
                                 DNI = tbPasajero.DNI,
                                 Genero = tbPasajero.SEXO,
                                 NumTel = tbPasajero.NUMERO_TELEFONICO,
                                 Email = tbPasajero.EMAIL,
                                 FecNac = tbPasajero.FECHA_NACIMIENTO,
                                 PaisDestino = tbPais.NOMBRE_PAIS
                             }).Take(100);

                foreach (var resultado in query)
                {
                    MigranteBE objMigranteBE = new MigranteBE();
                    objMigranteBE.CodMigrante = resultado.Codigo;
                    objMigranteBE.NomMigrante = resultado.Nombre;
                    objMigranteBE.ApeMigrante = resultado.Apellido;
                    objMigranteBE.Dni = resultado.DNI;
                    objMigranteBE.Genero = resultado.Genero.ElementAt(0);
                    objMigranteBE.NumTelefono = resultado.NumTel;
                    objMigranteBE.Email = resultado.Email;
                    objMigranteBE.FecNac = Convert.ToDateTime(resultado.FecNac);
                    objMigranteBE.PaisDestino = resultado.PaisDestino;

                    objListaBE.Add(objMigranteBE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objListaBE;
        }

        public List<MigranteBE> ListaMigrantesNacionales(string codPaisNacimiento, System.DateTime fecIni, System.DateTime fecFin)
        {
            AerolineaEntities MiAerolinea = new AerolineaEntities();
            List<MigranteBE> objListaBE = new List<MigranteBE>();

            try
            {
                var query = (from tbPasajero in MiAerolinea.PASAJERO
                             join tbReservacion in MiAerolinea.RESERVACION
                                        on tbPasajero.COD_PASAJERO equals tbReservacion.COD_PASAJERO
                             join tbVuelo in MiAerolinea.VUELO
                                        on tbReservacion.COD_VUELO equals tbVuelo.COD_VUELO
                             join tbRuta in MiAerolinea.RUTA
                                        on tbVuelo.COD_RUTA equals tbRuta.COD_RUTA
                             join tbLugar in MiAerolinea.LUGAR
                                        on tbRuta.COD_DESTINO equals tbLugar.COD_LUGAR
                             where tbPasajero.COD_PAIS == codPaisNacimiento &&
                                   tbLugar.COD_PAIS == codPaisNacimiento &&
                             tbVuelo.FECHA_LLEGADA >= fecIni &&
                             tbVuelo.FECHA_LLEGADA <= fecFin

                             select new
                             {
                                 Codigo = tbPasajero.COD_PASAJERO,
                                 Nombre = tbPasajero.NOMBRE_PASAJERO,
                                 Apellido = tbPasajero.APELLIDO_PASAJERO,
                                 DNI = tbPasajero.DNI,
                                 Genero = tbPasajero.SEXO,
                                 NumTel = tbPasajero.NUMERO_TELEFONICO,
                                 Email = tbPasajero.EMAIL,
                                 FecNac = tbPasajero.FECHA_NACIMIENTO,
                                 LugarDestino = tbLugar.NOMBRE_LUGAR
                             }).Take(100);

                foreach (var resultado in query)
                {
                    MigranteBE objMigranteBE = new MigranteBE();
                    objMigranteBE.CodMigrante = resultado.Codigo;
                    objMigranteBE.NomMigrante = resultado.Nombre;
                    objMigranteBE.ApeMigrante = resultado.Apellido;
                    objMigranteBE.Dni = resultado.DNI;
                    objMigranteBE.Genero = resultado.Genero.ElementAt(0);
                    objMigranteBE.NumTelefono = resultado.NumTel;
                    objMigranteBE.Email = resultado.Email;
                    objMigranteBE.FecNac = Convert.ToDateTime(resultado.FecNac);
                    objMigranteBE.LugarDestino = resultado.LugarDestino;

                    objListaBE.Add(objMigranteBE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objListaBE;
        }

        public List<MigranteBE> ListaMigrantesPaisesFechas(string codPaisOrigen, string codPaisDestino, System.DateTime fecIni, System.DateTime fecFin)
        {
            AerolineaEntities MiAerolinea = new AerolineaEntities();
            List<MigranteBE> objListaBE = new List<MigranteBE>();

            try
            {
                var codLOrigen = from tbLugar in MiAerolinea.LUGAR
                                 where tbLugar.COD_PAIS == codPaisOrigen
                                 select tbLugar.COD_LUGAR;

                var codLDestino = from tbLugar in MiAerolinea.LUGAR
                                  where tbLugar.COD_PAIS == codPaisDestino
                                  select tbLugar.COD_LUGAR;

                var query = (from tbPasajero in MiAerolinea.PASAJERO
                             join tbReservacion in MiAerolinea.RESERVACION
                                        on tbPasajero.COD_PASAJERO equals tbReservacion.COD_PASAJERO
                             join tbVuelo in MiAerolinea.VUELO
                                        on tbReservacion.COD_VUELO equals tbVuelo.COD_VUELO
                             join tbRuta in MiAerolinea.RUTA
                                        on tbVuelo.COD_RUTA equals tbRuta.COD_RUTA
                             where tbVuelo.FECHA_LLEGADA >= fecIni &&
                                   tbVuelo.FECHA_LLEGADA <= fecFin &&
                                   codLOrigen.Contains(tbRuta.COD_ORIGEN) &&
                                   codLDestino.Contains(tbRuta.COD_DESTINO)

                             select new
                             {
                                 Codigo = tbPasajero.COD_PASAJERO,
                                 Nombre = tbPasajero.NOMBRE_PASAJERO,
                                 Apellido = tbPasajero.APELLIDO_PASAJERO,
                                 DNI = tbPasajero.DNI,
                                 Genero = tbPasajero.SEXO,
                                 NumTel = tbPasajero.NUMERO_TELEFONICO,
                                 Email = tbPasajero.EMAIL,
                                 FecNac = tbPasajero.FECHA_NACIMIENTO
                             }).Take(100);

                foreach (var resultado in query)
                {
                    MigranteBE objMigranteBE = new MigranteBE();
                    objMigranteBE.CodMigrante = resultado.Codigo;
                    objMigranteBE.NomMigrante = resultado.Nombre;
                    objMigranteBE.ApeMigrante = resultado.Apellido;
                    objMigranteBE.Dni = resultado.DNI;
                    objMigranteBE.Genero = resultado.Genero.ElementAt(0);
                    objMigranteBE.NumTelefono = resultado.NumTel;
                    objMigranteBE.Email = resultado.Email;
                    objMigranteBE.FecNac = Convert.ToDateTime(resultado.FecNac);
                    objListaBE.Add(objMigranteBE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objListaBE;
        }

        public List<PaisBE> PaisMaximoMigrantes(string codPais, DateTime fecIni, DateTime fecFin)
        {
            AerolineaEntities MiAerolinea = new AerolineaEntities();
            List<PaisBE> paises = new List<PaisBE>();

            try
            {
                var codLOrigen = from tbLugar in MiAerolinea.LUGAR
                                 where tbLugar.COD_PAIS == codPais
                                 select tbLugar.COD_LUGAR;

                var codLPDestino = from tbLugar in MiAerolinea.LUGAR
                                   where !codLOrigen.Contains(tbLugar.COD_LUGAR)
                                   select tbLugar.COD_LUGAR;

                var query = ((from tbVuelo in MiAerolinea.VUELO
                              join tbRuta in MiAerolinea.RUTA
                              on tbVuelo.COD_RUTA equals tbRuta.COD_RUTA
                              join tbLugar in MiAerolinea.LUGAR
                              on tbRuta.COD_DESTINO equals tbLugar.COD_LUGAR
                              join tbPais in MiAerolinea.PAIS
                              on tbLugar.COD_PAIS equals tbPais.COD_PAIS
                              where codLOrigen.Contains(tbRuta.COD_ORIGEN)
                              && codLPDestino.Contains(tbRuta.COD_DESTINO)
                              && tbVuelo.FECHA_LLEGADA > fecIni
                              && tbVuelo.FECHA_LLEGADA < fecFin
                              select tbPais
                             ).GroupBy(x => x).Select(g => new
                             {
                                 CodPais = g.Key.COD_PAIS,
                                 NomPais = g.Key.NOMBRE_PAIS,
                                 Idioma = g.Key.IDIOMA,
                                 Moneda = g.Key.MONEDA,
                                 CantidadVuelos = g.Count()
                             })).OrderByDescending(x => x.CantidadVuelos);


                foreach (var item in query)
                {
                    PaisBE objBE = new PaisBE();
                    objBE.CodPais = item.CodPais;
                    objBE.NomPais = item.NomPais;
                    objBE.Idioma = item.Idioma;
                    objBE.Moneda = item.Moneda;
                    objBE.CantVuelos = item.CantidadVuelos;

                    paises.Add(objBE);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return paises;
        }
    }
}
