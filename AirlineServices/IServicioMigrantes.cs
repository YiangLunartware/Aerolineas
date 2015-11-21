using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AirlineServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioMigrantes" in both code and config file together.
    [ServiceContract]
    public interface IServicioMigrantes
    {
        [OperationContract]
        List<PaisBE> ListaPaises();

        [OperationContract]
        PaisBE ConsultaMaximoMigrantesNacionalidad(string codPaisNacimiento);

        [OperationContract]
        List<MigranteBE> ListaMigrantesInternacionales(string codPaisNacimiento, System.DateTime fecIni, System.DateTime fecFin);
        [OperationContract]
        List<MigranteBE> ListaMigrantesNacionales(string codPaisNacimiento, System.DateTime fecIni, System.DateTime fecFin);

        [OperationContract]
        List<MigranteBE> ListaMigrantesPaisesFechas(string codPaisOrigen, string codPaisDestino, System.DateTime fecIni, System.DateTime fecFin);

        [OperationContract]
        List<PaisBE> ListaPaisesMigrantes(string codPais, System.DateTime fecIni, System.DateTime fecFin);
    }

    [DataContract]
    [Serializable]
    public class PaisBE
    {
        private string _codPais;
        private string _nomPais;
        private string _moneda;
        private string _idioma;
        private int _cantVuelos;

        [DataMember]
        public string CodPais
        {
            get { return _codPais; }
            set { _codPais = value; }
        }
        [DataMember]
        public string NomPais
        {
            get { return _nomPais; }
            set { _nomPais = value; }
        }
        [DataMember]
        public string Moneda
        {
            get { return _moneda; }
            set { _moneda = value; }
        }
        [DataMember]
        public string Idioma
        {
            get { return _idioma; }
            set { _idioma = value; }
        }
        [DataMember]
        public int CantVuelos
        {
            get { return _cantVuelos; }
            set { _cantVuelos = value; }
        }
    }

    [DataContract]
    [Serializable]
    public class LugarBE
    {
        private string _codLugar;
        private string _nomLugar;
        private string _latitud;
        private string _longitud;
        private string _nomAeropuerto;
        private string _codPais;

        [DataMember]
        public string CodLugar
        {
            get { return _codLugar; }
            set { _codLugar = value; }
        }

        [DataMember]
        public string NomLugar
        {
            get { return _nomLugar; }
            set { _nomLugar = value; }
        }

        [DataMember]
        public string Latitud
        {
            get { return _latitud; }
            set { _latitud = value; }
        }

        [DataMember]
        public string Longitud
        {
            get { return _longitud; }
            set { _longitud = value; }
        }

        [DataMember]
        public string NomAeropuerto
        {
            get { return _nomAeropuerto; }
            set { _nomAeropuerto = value; }
        }

        [DataMember]
        public string CodPais
        {
            get { return _codPais; }
            set { _codPais = value; }
        }
    }

    [DataContract]
    [Serializable]
    public class MigranteBE
    {
        private string _codMigrante;
        private string _dni;
        private string _nomMigrante;
        private string _apeMigrante;
        private char _genero;
        private string _numTelefono;
        private string _email;
        private System.DateTime _fecNac;
        private string _codPaisNacion;
        private string _paisDestino;
        private string _lugarDestino;

        [DataMember]
        public string CodMigrante
        {
            get { return _codMigrante; }
            set { _codMigrante = value; }
        }
        [DataMember]
        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        [DataMember]
        public string NomMigrante
        {
            get { return _nomMigrante; }
            set { _nomMigrante = value; }
        }
        [DataMember]
        public string ApeMigrante
        {
            get { return _apeMigrante; }
            set { _apeMigrante = value; }
        }
        [DataMember]
        public char Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }
        [DataMember]
        public string NumTelefono
        {
            get { return _numTelefono; }
            set { _numTelefono = value; }
        }
        [DataMember]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        [DataMember]
        public System.DateTime FecNac
        {
            get { return _fecNac; }
            set { _fecNac = value; }
        }
        [DataMember]
        public string CodPaisNacion
        {
            get { return _codPaisNacion; }
            set { _codPaisNacion = value; }
        }
        [DataMember]
        public string PaisDestino
        {
            get { return _paisDestino; }
            set { _paisDestino = value; }
        }
        [DataMember]
        public string LugarDestino
        {
            get { return _lugarDestino; }
            set { _lugarDestino = value; }
        }
    }

    [DataContract]
    [Serializable]
    public class RutaBE
    {
        private string _origen;
        private string _destino;
        private int _cantVuelos;

        [DataMember]
        public string Origen
        {
            get { return _origen; }
            set { _origen = value; }
        }

        [DataMember]
        public string Destino
        {
            get { return _destino; }
            set { _destino = value; }
        }

        [DataMember]
        public int cantVuelos
        {
            get { return _cantVuelos; }
            set { _cantVuelos = value; }
        }
    }
    
}
