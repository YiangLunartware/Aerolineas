using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AirlineServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioHistorialPasajero" in both code and config file together.
    [ServiceContract]
    public interface IServicioHistorialPasajero
    {
        [OperationContract]
        List<Pasajero> GetAllHistorialPasajero();

        [OperationContract]
        List<Pasajero> GetHistorialPasajeroXNombrePasajero(String nomPasajero, System.DateTime fecIni, System.DateTime fecFin);

        [OperationContract]
        List<Pasajero> GetHistorialPasajeroXDNI(String dni, System.DateTime fecIni, System.DateTime fecFin);

        [OperationContract]
        List<Pasajero> GetCantidadVuelosXPasajero(String codPasajero, System.DateTime fecIni, System.DateTime fecFin);

        [OperationContract]
        List<Pasajero> GetAllPasajeros();
    }

    [DataContract]
    [Serializable]
    public class Pasajero
    {
        private String _codPasajero;
        private String _nomPasajero;
        private String _lugarOrigen;
        private String _lugarDestino;
        private System.DateTime _fechaDespeque;
        private System.DateTime _fechaLlegada;
        private String _DNI;
        private String _email;
        private String _numTelefono;
        private String _nacionalidad;
        private String _genero;
        private int _cantVuelos;

        [DataMember]
        public string CodPasajero
        {
            get { return _codPasajero; }
            set { _codPasajero = value; }
        }

        [DataMember]
        public String NomPasajero
        {
            get { return _nomPasajero; }
            set { _nomPasajero = value; }
        }

        [DataMember]
        public String LugarOrigen
        {
            get { return _lugarOrigen; }
            set { _lugarOrigen = value; }
        }

        [DataMember]
        public String LugarDestino
        {
            get { return _lugarDestino; }
            set { _lugarDestino = value; }
        }

        [DataMember]
        public System.DateTime FechaDespeque
        {
            get { return _fechaDespeque; }
            set { _fechaDespeque = value; }
        }

        [DataMember]
        public System.DateTime FechaLlegada
        {
            get { return _fechaLlegada; }
            set { _fechaLlegada = value; }
        }

        [DataMember]
        public String DNI
        {
            get { return _DNI; }
            set { _DNI = value; }
        }

        [DataMember]
        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        [DataMember]
        public String NumTelefono
        {
            get { return _numTelefono; }
            set { _numTelefono = value; }
        }

        [DataMember]
        public String Nacionalidad
        {
            get { return _nacionalidad; }
            set { _nacionalidad = value; }
        }

        [DataMember]
        public String Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        [DataMember]
        public int CantVuelos
        {
            get { return _cantVuelos; }
            set { _cantVuelos = value; }
        }
    }
}
