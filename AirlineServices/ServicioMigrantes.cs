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
                var query = MiAerolinea.PAIS.ToList();

                foreach (var resultado in query)
                {
                    PaisBE objPaisBE = new PaisBE();

                    objPaisBE.CodPais = resultado.COD_PAIS;
                    objPaisBE.NomPais = resultado.NOMBRE_PAIS;

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
                var lCodsPasajeros = MiAerolinea.PASAJERO
                    .Where(x => x.COD_PAIS == codPaisNacimiento)
                    .Select(x=>x.COD_PASAJERO)
                    .ToList();
                var lCodVuelos = MiAerolinea.RESERVACION
                    .Where(x => lCodsPasajeros.Contains(x.COD_PASAJERO))
                    .Where(y => y.TOMO_VUELO == true)
                    .Select(m => m.COD_VUELO)
                    .ToList();
                var lCodPaisCant = MiAerolinea.VUELO
                    .Where(x => lCodVuelos.Contains(x.COD_VUELO))
                    .Where(y => y.RUTA.TIPO_RUTA == "INTERNACIONAL")
                    .GroupBy(m => m.RUTA.LUGAR.COD_PAIS)
                    .Select(g => new
                    {
                        CodPais = g.Key,
                        Cantidad = g.Count()
                    })
                    .ToList()
                    .OrderByDescending(n => n.Cantidad)
                    .First();

                var pais = MiAerolinea.PAIS
                    .Where(x => x.COD_PAIS == lCodPaisCant.CodPais)
                    .Select(p => new
                    {
                        CodPais = p.COD_PAIS,
                        NomPais = p.NOMBRE_PAIS,
                        Idioma = p.IDIOMA,
                        Moneda = p.MONEDA,
                        CantVuelos = lCodPaisCant.Cantidad
                    })
                    .First();

                objPaisBE.CodPais = pais.CodPais;
                objPaisBE.NomPais = pais.NomPais;
                objPaisBE.Idioma = pais.Idioma;
                objPaisBE.Moneda = pais.Moneda;
                objPaisBE.CantVuelos = pais.CantVuelos;
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
                                   tbPasajero.COD_PAIS == codPaisOrigen &&
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

        public List<PaisBE> ListaPaisesMigrantes(string codPais, DateTime fecIni, DateTime fecFin)
        {
            AerolineaEntities MiAerolinea = new AerolineaEntities();
            List<PaisBE> paises = new List<PaisBE>();

            try
            {
                var query = MiAerolinea.RESERVACION
                    .Where(x =>
                    x.PASAJERO.COD_PAIS == codPais &&
                    x.VUELO.RUTA.LUGAR.COD_PAIS != codPais &&
                    x.VUELO.FECHA_LLEGADA > fecIni &&
                    x.VUELO.FECHA_LLEGADA < fecFin)
                    .Select(y => y.VUELO.RUTA.LUGAR.PAIS)
                    .GroupBy(z => z)
                    .Select(g => new
                    {
                        CodPais = g.Key.COD_PAIS,
                        NomPais = g.Key.NOMBRE_PAIS,
                        Idioma = g.Key.IDIOMA,
                        Moneda = g.Key.MONEDA,
                        CantidadVuelos = g.Count()
                    })
                    .OrderByDescending(h => h.CantidadVuelos);

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
