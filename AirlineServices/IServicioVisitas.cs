using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AirlineServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioVisitas" in both code and config file together.
    [ServiceContract]
    public interface IServicioVisitas
    {
        [OperationContract]
        List<Visitas> GetVisitas_X_Fecha(DateTime fechaInicial, DateTime fechaFinal);
        [OperationContract]
        List<Visitas> GetVisitas_X_LugarOrigen(string LugarOrigen, DateTime fechaInicial, DateTime fechaFinal);
        [OperationContract]
        List<Visitas> AllVisitas();
        [OperationContract]
        List<Visitas> RankingVisitasDestinosPeruanos(DateTime fechaLLegada);
    }

    [DataContract]
    [Serializable]
    public class Visitas  // definimos la clase Vendedor como Data Contractual
    {
        //Miembros privados
        private String _nombrePasajero;
        private DateTime _ApellidoPasajero;
        private DateTime _fechaDespeque;
        private DateTime _fechaLlegada;
        private String _nomRuta;
        private String _codigoDestino;

        [DataMember]
        public String NombrePasajero
        {
            get { return _nombrePasajero; }
            set { _nombrePasajero = value; }
        }

        [DataMember]
        public DateTime ApellidoPasajero
        {
            get { return _ApellidoPasajero; }
            set { _ApellidoPasajero = value; }
        }

        [DataMember]
        public DateTime FechaDespeque
        {
            get { return _fechaDespeque; }
            set { _fechaDespeque = value; }
        }

        [DataMember]
        public DateTime FechaLlegada
        {
            get { return _fechaLlegada; }
            set { _fechaLlegada = value; }
        }

        [DataMember]
        public String NomRuta
        {
            get { return _nomRuta; }
            set { _nomRuta = value; }
        }

        [DataMember]
        public String CodigoDestino
        {
            get { return _codigoDestino; }
            set { _codigoDestino = value; }
        }

        // Cada propiedad es un DataMember de la Data Contractual

        private int _rankingVisitasDestinosPeruanos;
        private string _nombreLugar;

        [DataMember]
        public int RankingVisitasDestinosPeruanos
        {
            get { return _rankingVisitasDestinosPeruanos; }
            set { _rankingVisitasDestinosPeruanos = value; }
        }

        [DataMember]
        public string NombreLugar
        {
            get { return _nombreLugar; }
            set { _nombreLugar = value; }
        }
    }
}
