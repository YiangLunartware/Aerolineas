using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace AirlineServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioVuelos" in both code and config file together.
    public class ServicioVuelos : IServicioVuelos
    {
        public Vuelos ListaVueloPorDescripcion(String descripcion)
        {
            AerolineaEntities MisVuelos = new AerolineaEntities();
            Vuelos objVuelosBE = new Vuelos();

            try
            {

                var query = MisVuelos.usp_ListaVueloPorDescripcion(descripcion).FirstOrDefault();


                objVuelosBE.CodVuelo = query.COD_VUELO;
                objVuelosBE.DescVuelo = query.DESCRIPCION_VUELO;
                objVuelosBE.FecDespegue = Convert.ToDateTime(query.FECHA_DESPEQUE);
                objVuelosBE.FecLlegada = Convert.ToDateTime(query.FECHA_LLEGADA);
                objVuelosBE.EstadoVuelo = Convert.ToBoolean(query.ESTADO_VUELO);
                objVuelosBE.PrecioVuelo = Convert.ToDecimal(query.PRECIO_VUELO);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objVuelosBE;

        }

        public List<Vuelos> ListaVueloPorEstado(Boolean estado, DateTime fecini, DateTime fecfin)
        {
            AerolineaEntities MisVuelos = new AerolineaEntities();
            List<Vuelos> objListaVuelos = new List<Vuelos>();

            try
            {

                var query = MisVuelos.usp_ListaVueloPorEstadoFechas(estado, fecini, fecfin).Take(100);

                foreach (var resultado in query)
                {
                    Vuelos objVuelosBE = new Vuelos();

                    objVuelosBE.CodVuelo = resultado.COD_VUELO;
                    objVuelosBE.DescVuelo = resultado.DESCRIPCION_VUELO;
                    objVuelosBE.FecDespegue = Convert.ToDateTime(resultado.FECHA_DESPEQUE);
                    objVuelosBE.FecLlegada = Convert.ToDateTime(resultado.FECHA_LLEGADA);
                    objVuelosBE.EstadoVuelo = Convert.ToBoolean(resultado.ESTADO_VUELO);
                    objVuelosBE.PrecioVuelo = Convert.ToDecimal(resultado.PRECIO_VUELO);
                    objListaVuelos.Add(objVuelosBE);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objListaVuelos;

        }


        public List<Vuelos> ListaVueloPorFecha(DateTime fecini, DateTime fecfin)
        {
            AerolineaEntities MisVuelos = new AerolineaEntities();
            List<Vuelos> objListaVuelos = new List<Vuelos>();

            try
            {

                var query = MisVuelos.usp_ListaVueloPorFecha(fecini, fecfin).Take(100);

                foreach (var resultado in query)
                {
                    Vuelos objVuelosBE = new Vuelos();


                    objVuelosBE.CodVuelo = resultado.COD_VUELO;
                    objVuelosBE.DescVuelo = resultado.DESCRIPCION_VUELO;
                    objVuelosBE.FecDespegue = Convert.ToDateTime(resultado.FECHA_DESPEQUE);
                    objVuelosBE.FecLlegada = Convert.ToDateTime(resultado.FECHA_LLEGADA);
                    objVuelosBE.EstadoVuelo = Convert.ToBoolean(resultado.ESTADO_VUELO);
                    objVuelosBE.PrecioVuelo = Convert.ToDecimal(resultado.PRECIO_VUELO);
                    objListaVuelos.Add(objVuelosBE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objListaVuelos;

        }

        public List<Vuelos> ListaVueloPorPrecio(decimal precio, DateTime fecini, DateTime fecfin)
        {
            AerolineaEntities MisVuelos = new AerolineaEntities();
            List<Vuelos> objListaVuelos = new List<Vuelos>();

            try
            {

                var query = MisVuelos.usp_ListaVueloPorPrecioFechas(precio, fecini, fecfin).Take(100);

                foreach (var resultado in query)
                {
                    Vuelos objVuelosBE = new Vuelos();


                    objVuelosBE.CodVuelo = resultado.COD_VUELO;
                    objVuelosBE.DescVuelo = resultado.DESCRIPCION_VUELO;
                    objVuelosBE.FecDespegue = Convert.ToDateTime(resultado.FECHA_DESPEQUE);
                    objVuelosBE.FecLlegada = Convert.ToDateTime(resultado.FECHA_LLEGADA);
                    objVuelosBE.EstadoVuelo = Convert.ToBoolean(resultado.ESTADO_VUELO);
                    objVuelosBE.PrecioVuelo = Convert.ToDecimal(resultado.PRECIO_VUELO);
                    objListaVuelos.Add(objVuelosBE);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objListaVuelos;

        }

        public List<Vuelos> ListaVuelosPorCapacidad(int capacidad, DateTime fecini, DateTime fecfin)
        {
            AerolineaEntities MisVuelos = new AerolineaEntities();
            List<Vuelos> objListaVuelos = new List<Vuelos>();
            try
            {
                var query = MisVuelos.usp_ListaVuelosPorCapacidadFechas(capacidad, fecini, fecfin).Take(100);

                foreach (var resultado in query)
                {
                    Vuelos objVuelosBE = new Vuelos();
                    objVuelosBE.CodVuelo = resultado.COD_VUELO;
                    objVuelosBE.DescVuelo = resultado.DESCRIPCION_VUELO;
                    objVuelosBE.FecDespegue = Convert.ToDateTime(resultado.FECHA_DESPEQUE);
                    objVuelosBE.FecLlegada = Convert.ToDateTime(resultado.FECHA_LLEGADA);
                    objVuelosBE.EstadoVuelo = Convert.ToBoolean(resultado.ESTADO_VUELO);
                    objVuelosBE.PrecioVuelo = Convert.ToDecimal(resultado.PRECIO_VUELO);
                    objVuelosBE.Capacidad = Convert.ToInt32(resultado.CAPACIDAD);

                    objListaVuelos.Add(objVuelosBE);
                }

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListaVuelos;
        }

        public List<Vuelos> ListaVueloXDescipcion()
        {
            AerolineaEntities MisVuelos = new AerolineaEntities();
            List<Vuelos> objListaVuelos = new List<Vuelos>();
            try
            {
                var query = MisVuelos.usp_ListaVueloXDescripcion().Take(100);

                foreach (var resultado in query)
                {
                    Vuelos objVuelosBE = new Vuelos();
                    objVuelosBE.DescVuelo = resultado;

                    objListaVuelos.Add(objVuelosBE);
                }

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListaVuelos;
        }


        public List<Vuelos> ListaPrecios()
        {
            AerolineaEntities MisVuelos = new AerolineaEntities();
            List<Vuelos> objListaVuelos = new List<Vuelos>();
            try
            {
                var query = MisVuelos.usp_ListaVueloPrecios();

                foreach (var resultado in query)
                {
                    Vuelos objVuelosBE = new Vuelos();
                    objVuelosBE.PrecioVuelo = Convert.ToDecimal(resultado);

                    objListaVuelos.Add(objVuelosBE);
                }

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListaVuelos;
        }


        public List<Vuelos> ListaAvionCapacidad()
        {
            AerolineaEntities MisVuelos = new AerolineaEntities();
            List<Vuelos> objListaVuelos = new List<Vuelos>();
            try
            {
                var query = MisVuelos.usp_ListaAvionCapacidad();

                foreach (var resultado in query)
                {
                    Vuelos objVuelosBE = new Vuelos();
                    objVuelosBE.Capacidad = Convert.ToInt32(resultado);

                    objListaVuelos.Add(objVuelosBE);
                }

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListaVuelos;
        }
    }
}
