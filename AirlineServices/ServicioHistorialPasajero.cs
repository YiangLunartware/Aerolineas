using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AirlineServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioHistorialPasajero" in both code and config file together.
    public class ServicioHistorialPasajero : IServicioHistorialPasajero
    {
        public List<Pasajero> GetAllHistorialPasajero()
        {
            List<Pasajero> lista = new List<Pasajero>();

            try
            {
                AerolineaEntities miAerolinea = new AerolineaEntities();

                var query = miAerolinea.RESERVACION.ToList()
                    .Where(y => y.TOMO_VUELO == true)
                    .Select(x => new
                    {
                        CodPasajero = x.COD_PASAJERO,
                        NomCompletoPasajero = x.PASAJERO.APELLIDO_PASAJERO + ", " + x.PASAJERO.NOMBRE_PASAJERO,
                        LugarOrigen = x.VUELO.RUTA.LUGAR1.NOMBRE_LUGAR,
                        LugarDestino = x.VUELO.RUTA.LUGAR.NOMBRE_LUGAR,
                        FechaDespeque = x.VUELO.FECHA_DESPEQUE,
                        FechaLlegada = x.VUELO.FECHA_LLEGADA,
                        DNI = x.PASAJERO.DNI,
                        Email = x.PASAJERO.EMAIL,
                        Telefono = x.PASAJERO.NUMERO_TELEFONICO,
                        Nacionalidad = x.PASAJERO.NACIONALIDAD,
                        Genero = x.PASAJERO.SEXO
                    })
                    .Take(100);

                foreach (var item in query)
                {
                    Pasajero objPasajero = new Pasajero();
                    objPasajero.CodPasajero = item.CodPasajero;
                    objPasajero.NomPasajero = item.NomCompletoPasajero;
                    objPasajero.LugarOrigen = item.LugarOrigen;
                    objPasajero.LugarDestino = item.LugarDestino;
                    objPasajero.FechaDespeque = Convert.ToDateTime(item.FechaDespeque);
                    objPasajero.FechaLlegada = Convert.ToDateTime(item.FechaLlegada);
                    objPasajero.DNI = item.DNI;
                    objPasajero.Email = item.Email;
                    objPasajero.NumTelefono = item.Telefono;
                    objPasajero.Nacionalidad = item.Nacionalidad;
                    objPasajero.Genero = item.Genero;

                    lista.Add(objPasajero);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lista;
        }

        public List<Pasajero> GetHistorialPasajeroXNombrePasajero(string nomPasajero, DateTime fecIni, DateTime fecFin)
        {
            List<Pasajero> lista = new List<Pasajero>();

            try
            {
                AerolineaEntities miAerolinea = new AerolineaEntities();

                var query = miAerolinea.RESERVACION.ToList()
                    .Where(y => y.TOMO_VUELO == true)
                    .Where(m => m.PASAJERO.NOMBRE_PASAJERO.Contains(nomPasajero))
                    .Where(n => n.VUELO.FECHA_DESPEQUE >= fecIni)
                    .Where(q => q.VUELO.FECHA_LLEGADA <= fecFin)
                    .Select(x => new
                    {
                        CodPasajero = x.COD_PASAJERO,
                        NomCompletoPasajero = x.PASAJERO.APELLIDO_PASAJERO + ", " + x.PASAJERO.NOMBRE_PASAJERO,
                        LugarOrigen = x.VUELO.RUTA.LUGAR1.NOMBRE_LUGAR,
                        LugarDestino = x.VUELO.RUTA.LUGAR.NOMBRE_LUGAR,
                        FechaDespeque = x.VUELO.FECHA_DESPEQUE,
                        FechaLlegada = x.VUELO.FECHA_LLEGADA,
                        DNI = x.PASAJERO.DNI,
                        Email = x.PASAJERO.EMAIL,
                        Telefono = x.PASAJERO.NUMERO_TELEFONICO,
                        Nacionalidad = x.PASAJERO.NACIONALIDAD,
                        Genero = x.PASAJERO.SEXO
                    });

                foreach (var item in query)
                {
                    Pasajero objPasajero = new Pasajero();
                    objPasajero.CodPasajero = item.CodPasajero;
                    objPasajero.NomPasajero = item.NomCompletoPasajero;
                    objPasajero.LugarOrigen = item.LugarOrigen;
                    objPasajero.LugarDestino = item.LugarDestino;
                    objPasajero.FechaDespeque = Convert.ToDateTime(item.FechaDespeque);
                    objPasajero.FechaLlegada = Convert.ToDateTime(item.FechaLlegada);
                    objPasajero.DNI = item.DNI;
                    objPasajero.Email = item.Email;
                    objPasajero.NumTelefono = item.Telefono;
                    objPasajero.Nacionalidad = item.Nacionalidad;
                    objPasajero.Genero = item.Genero;

                    lista.Add(objPasajero);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lista;
        }

        public List<Pasajero> GetHistorialPasajeroXDNI(string dni, DateTime fecIni, DateTime fecFin)
        {
            List<Pasajero> lista = new List<Pasajero>();

            try
            {
                AerolineaEntities miAerolinea = new AerolineaEntities();

                var query = miAerolinea.RESERVACION.ToList()
                    .Where(y => y.TOMO_VUELO == true)
                    .Where(m => m.PASAJERO.DNI == dni)
                    .Where(n => n.VUELO.FECHA_DESPEQUE >= fecIni)
                    .Where(q => q.VUELO.FECHA_LLEGADA <= fecFin)
                    .Select(x => new
                    {
                        CodPasajero = x.COD_PASAJERO,
                        NomCompletoPasajero = x.PASAJERO.APELLIDO_PASAJERO + ", " + x.PASAJERO.NOMBRE_PASAJERO,
                        LugarOrigen = x.VUELO.RUTA.LUGAR1.NOMBRE_LUGAR,
                        LugarDestino = x.VUELO.RUTA.LUGAR.NOMBRE_LUGAR,
                        FechaDespeque = x.VUELO.FECHA_DESPEQUE,
                        FechaLlegada = x.VUELO.FECHA_LLEGADA,
                        DNI = x.PASAJERO.DNI,
                        Email = x.PASAJERO.EMAIL,
                        Telefono = x.PASAJERO.NUMERO_TELEFONICO,
                        Nacionalidad = x.PASAJERO.NACIONALIDAD,
                        Genero = x.PASAJERO.SEXO
                    });

                foreach (var item in query)
                {
                    Pasajero objPasajero = new Pasajero();
                    objPasajero.CodPasajero = item.CodPasajero;
                    objPasajero.NomPasajero = item.NomCompletoPasajero;
                    objPasajero.LugarOrigen = item.LugarOrigen;
                    objPasajero.LugarDestino = item.LugarDestino;
                    objPasajero.FechaDespeque = Convert.ToDateTime(item.FechaDespeque);
                    objPasajero.FechaLlegada = Convert.ToDateTime(item.FechaLlegada);
                    objPasajero.DNI = item.DNI;
                    objPasajero.Email = item.Email;
                    objPasajero.NumTelefono = item.Telefono;
                    objPasajero.Nacionalidad = item.Nacionalidad;
                    objPasajero.Genero = item.Genero;

                    lista.Add(objPasajero);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lista;
        }

        public List<Pasajero> GetCantidadVuelosXPasajero(string codPasajero, DateTime fecIni, DateTime fecFin)
        {
            List<Pasajero> lista = new List<Pasajero>();

            try
            {
                AerolineaEntities miAerolinea = new AerolineaEntities();

                var query = miAerolinea.RESERVACION.ToList()
                    .Where(y => y.TOMO_VUELO == true)
                    .Where(m => m.PASAJERO.COD_PASAJERO == codPasajero)
                    .Where(n => n.VUELO.FECHA_DESPEQUE >= fecIni)
                    .Where(q => q.VUELO.FECHA_LLEGADA <= fecFin)
                    .Select( x => new
                    {
                        CodPasajero = x.COD_PASAJERO,
                        NomCompletoPasajero = x.PASAJERO.APELLIDO_PASAJERO + ", " + x.PASAJERO.NOMBRE_PASAJERO,
                        LugarOrigen = x.VUELO.RUTA.LUGAR1.NOMBRE_LUGAR,
                        LugarDestino = x.VUELO.RUTA.LUGAR.NOMBRE_LUGAR,
                        FechaDespeque = x.VUELO.FECHA_DESPEQUE,
                        FechaLlegada = x.VUELO.FECHA_LLEGADA,
                        DNI = x.PASAJERO.DNI,
                        Email = x.PASAJERO.EMAIL,
                        Telefono = x.PASAJERO.NUMERO_TELEFONICO,
                        Nacionalidad = x.PASAJERO.NACIONALIDAD,
                        Genero = x.PASAJERO.SEXO
                    })
                    .OrderBy(y=>y.FechaLlegada);
                
                foreach (var item in query)
                {
                    Pasajero objPasajero = new Pasajero();
                    objPasajero.CodPasajero = item.CodPasajero;
                    objPasajero.NomPasajero = item.NomCompletoPasajero;
                    objPasajero.LugarOrigen = item.LugarOrigen;
                    objPasajero.LugarDestino = item.LugarDestino;
                    objPasajero.FechaDespeque = Convert.ToDateTime(item.FechaDespeque);
                    objPasajero.FechaLlegada = Convert.ToDateTime(item.FechaLlegada);
                    objPasajero.DNI = item.DNI;
                    objPasajero.Email = item.Email;
                    objPasajero.NumTelefono = item.Telefono;
                    objPasajero.Nacionalidad = item.Nacionalidad;
                    objPasajero.Genero = item.Genero;
                    objPasajero.CantVuelos = query.Count();

                    lista.Add(objPasajero);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lista;
        }
        
        public List<Pasajero> GetAllPasajeros()
        {
            List<Pasajero> lista = new List<Pasajero>();

            try
            {
                AerolineaEntities miAerolinea = new AerolineaEntities();

                var query = miAerolinea.PASAJERO.ToList();

                foreach (var item in query)
                {
                    Pasajero objPasajero = new Pasajero();

                    objPasajero.CodPasajero = item.COD_PASAJERO;

                    objPasajero.NomPasajero = item.APELLIDO_PASAJERO + ", " + item.NOMBRE_PASAJERO;
                    objPasajero.DNI = item.DNI;
                    objPasajero.Email = item.EMAIL;
                    objPasajero.NumTelefono = item.NUMERO_TELEFONICO;
                    objPasajero.Nacionalidad = item.NACIONALIDAD;
                    objPasajero.Genero = item.SEXO;

                    lista.Add(objPasajero);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;
        }
    }
}
