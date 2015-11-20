using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AirlineServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioVuelos" in both code and config file together.
    [ServiceContract]
    public interface IServicioVuelos
    {
        [OperationContract]
        List<Vuelos> ListaVueloXDescipcion();

        [OperationContract]
        List<Vuelos> ListaPrecios();

        [OperationContract]
        List<Vuelos> ListaAvionCapacidad();

        [OperationContract]
        Vuelos ListaVueloPorDescripcion(String descripcion);

        [OperationContract]
        List<Vuelos> ListaVueloPorEstado(Boolean estado, DateTime fecini, DateTime fecfin);

        [OperationContract]
        List<Vuelos> ListaVueloPorFecha(DateTime fecini, DateTime fecfin);

        [OperationContract]
        List<Vuelos> ListaVueloPorPrecio(Decimal precio, DateTime fecini, DateTime fecfin);

        [OperationContract]
        List<Vuelos> ListaVuelosPorCapacidad(int capacidad, DateTime fecini, DateTime fecfin);
    }

    [DataContract]
    [Serializable]
    public class Vuelos 
    {
        private String _codVuelo;
        private String _descVuelo;
        private System.DateTime _fecDespegue;
        private System.DateTime _fecLlegada;
        private System.TimeSpan _horaDespegue;
        private System.TimeSpan _horaLlegada;
        private Boolean _estadoVuelo;
        private Decimal _precioVuelo;
        private String _codAvion;
        private String _codRuta;

        private int _capacidad;
        private String _nomRuta;
        private int _demanda;

        [DataMember]
        public String CodVuelo
        {
            get { return this._codVuelo; }
            set { this._codVuelo = value; }
        }

        [DataMember]
        public String DescVuelo
        {
            get { return this._descVuelo; }
            set { this._descVuelo = value; }
        }

        [DataMember]
        public String CodAvion
        {
            get { return this._codAvion; }
            set { this._codAvion = value; }
        }

        [DataMember]
        public String CodRuta
        {
            get { return this._codRuta; }
            set { this._codRuta = value; }
        }

        [DataMember]
        public System.DateTime FecDespegue
        {
            get { return this._fecDespegue; }
            set { this._fecDespegue = value; }
        }

        [DataMember]
        public System.DateTime FecLlegada
        {
            get { return this._fecLlegada; }
            set { this._fecLlegada = value; }
        }

        [DataMember]
        public System.TimeSpan HoraDespegue
        {
            get { return this._horaDespegue; }
            set { this._horaDespegue = value; }
        }

        [DataMember]
        public System.TimeSpan HoraLlegada
        {
            get { return this._horaLlegada; }
            set { this._horaLlegada = value; }
        }

        [DataMember]
        public Boolean EstadoVuelo
        {
            get { return this._estadoVuelo; }
            set { this._estadoVuelo = value; }
        }

        [DataMember]
        public Decimal PrecioVuelo
        {
            get { return this._precioVuelo; }
            set { this._precioVuelo = value; }
        }

        [DataMember]
        public int Capacidad
        {
            get { return this._capacidad; }
            set { this._capacidad = value; }
        }

        [DataMember]
        public String NomRuta
        {
            get { return this._nomRuta; }
            set { this._nomRuta = value; }
        }

        [DataMember]
        public int Demanda
        {
            get { return this._demanda; }
            set { this._demanda = value; }
        }

    }

    [DataContract]
    [Serializable]
    public class Avion
    {
        private int capacidad;

        [DataMember]
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
    }
}
