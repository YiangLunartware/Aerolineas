using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AirlineServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioVisitas" in both code and config file together.
    public class ServicioVisitas : IServicioVisitas
    {
<<<<<<< HEAD
        
        public List<Visitas> GetVisitas_X_Fecha(DateTime fechaInicial, DateTime fechaFinal)
        {
            AerolineaEntities misAerolineas = new AerolineaEntities();
            List<Visitas> objListaVisitas = new List<Visitas>();
            
            try
            {
                // Obtenemos con LINQ el registro a consultar
                var query = (from objVisitas in misAerolineas.VW_VISITAS
                             let fullName = objVisitas.NOMBRE_PASAJERO + "_" + objVisitas.APELLIDO_PASAJERO
                             where objVisitas.FECHA_DESPEQUE >= fechaInicial &&
                                    objVisitas.FECHA_LLEGADA <= fechaFinal
                                    
                             select new { fullName, objVisitas.NOM_RUTA, objVisitas.FECHA_DESPEQUE, objVisitas.FECHA_LLEGADA }).Take(100);
                //objPasajero.NOMBRE_PASAJERO + ' ' + objPasajero.APELLIDO_PASAJERO
                // ,objRuta.NOM_RUTA ).FirstOrDefault();
                
                foreach (var resultado in query)
                {
                    Visitas objVisitasBE = new Visitas();
                    //Obtenemos los datos del vendedor
                    objVisitasBE.NombrePasajero = resultado.fullName;
                    objVisitasBE.NomRuta = resultado.NOM_RUTA;
                    objVisitasBE.FechaDespeque = Convert.ToDateTime(resultado.FECHA_DESPEQUE);
                    objVisitasBE.FechaLlegada = Convert.ToDateTime(resultado.FECHA_LLEGADA);

                    objListaVisitas.Add(objVisitasBE);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objListaVisitas;
        }

        public List<Visitas> GetVisitas_X_LugarOrigen(string LugarOrigen, DateTime fechaInicial, DateTime fechaFinal)
        {
            AerolineaEntities misAerolineas = new AerolineaEntities();
            List<Visitas> objListaVisitasDestinos = new List<Visitas>();
            
            try
            {
                // Obtenemos con LINQ el registro a consultar
                var query = (from objVisitas in misAerolineas.VW_VISITAS
                             let fullName = objVisitas.NOMBRE_PASAJERO + "_" + objVisitas.APELLIDO_PASAJERO
                             where objVisitas.NOM_RUTA.StartsWith(LugarOrigen) || objVisitas.NOM_RUTA.Contains(LugarOrigen) &&
                                    objVisitas.TOMO_VUELO == true &&
                                    objVisitas.ESTADO_VUELO == false &&
                                    objVisitas.FECHA_DESPEQUE >= fechaInicial &&
                                    objVisitas.FECHA_LLEGADA <= fechaFinal &&
                                    objVisitas.COD_RUTA.StartsWith("RULLI")
                             select new { fullName, objVisitas.NOM_RUTA, objVisitas.FECHA_DESPEQUE, objVisitas.FECHA_LLEGADA }).Take(100);
                //objPasajero.NOMBRE_PASAJERO + ' ' + objPasajero.APELLIDO_PASAJERO
                // ,objRuta.NOM_RUTA ).FirstOrDefault();


                foreach (var resultado in query)
                {
                    Visitas objVisitasBE = new Visitas();
                    //Obtenemos los datos del vendedor
                    objVisitasBE.NombrePasajero = resultado.fullName;
                    objVisitasBE.NomRuta = resultado.NOM_RUTA;
                    objVisitasBE.FechaDespeque = Convert.ToDateTime(resultado.FECHA_DESPEQUE);
                    objVisitasBE.FechaLlegada = Convert.ToDateTime(resultado.FECHA_LLEGADA);

                    
                    // objListaReservacion.Add(objReservacionBE);
                    objListaVisitasDestinos.Add(objVisitasBE);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objListaVisitasDestinos;
        }

        public List<Visitas> AllVisitas()
        {
            AerolineaEntities misAerolineas = new AerolineaEntities();
            List<Visitas> objListaVisitas = new List<Visitas>();
            
            try
            {
                // Obtenemos con LINQ el registro a consultar
                var query = (from objVisitas in misAerolineas.VW_VISITAS
                             let fullName = objVisitas.NOMBRE_PASAJERO + "_" + objVisitas.APELLIDO_PASAJERO
                             
                             select new { fullName, objVisitas.NOM_RUTA }).Take(100);
                
                foreach (var resultado in query)
                {
                    Visitas objVisitasBE = new Visitas();
                    objVisitasBE.NombrePasajero = resultado.fullName;
                    objVisitasBE.NomRuta = resultado.NOM_RUTA;

                    objListaVisitas.Add(objVisitasBE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objListaVisitas;
        }

        public List<Visitas> RankingVisitasDestinosPeruanos(DateTime fechaLLegada)
        {
            AerolineaEntities misAerolineas = new AerolineaEntities();
            List<Visitas> RankingVisitasDestinosPeruanos = new List<Visitas>();

            /*
            try
            {
                
                var query = misAerolineas.(fechaLLegada).Take(100);


                foreach (var resultado in query)
                {

                    
                    Visitas objVisitasBE = new Visitas();
                    objVisitasBE.RankingVisitasDestinosPeruanos = Convert.ToInt32(resultado.RANKING);
                    objVisitasBE.NombreLugar = resultado.NOMBRE_LUGAR;
                    objVisitasBE.CodigoDestino = resultado.COD_DESTINO;

                    RankingVisitasDestinosPeruanos.Add(objVisitasBE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            */

            return RankingVisitasDestinosPeruanos;
=======
        public void DoWork()
        {
>>>>>>> origin/master
        }
    }
}
