﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.17929
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteMVC.ProxyHistorialPasajero {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pasajero", Namespace="http://schemas.datacontract.org/2004/07/AirlineServices")]
    [System.SerializableAttribute()]
    public partial class Pasajero : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CantVuelosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodPasajeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DNIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaDespequeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaLlegadaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GeneroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LugarDestinoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LugarOrigenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NacionalidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomPasajeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumTelefonoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CantVuelos {
            get {
                return this.CantVuelosField;
            }
            set {
                if ((this.CantVuelosField.Equals(value) != true)) {
                    this.CantVuelosField = value;
                    this.RaisePropertyChanged("CantVuelos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodPasajero {
            get {
                return this.CodPasajeroField;
            }
            set {
                if ((object.ReferenceEquals(this.CodPasajeroField, value) != true)) {
                    this.CodPasajeroField = value;
                    this.RaisePropertyChanged("CodPasajero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DNI {
            get {
                return this.DNIField;
            }
            set {
                if ((object.ReferenceEquals(this.DNIField, value) != true)) {
                    this.DNIField = value;
                    this.RaisePropertyChanged("DNI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaDespeque {
            get {
                return this.FechaDespequeField;
            }
            set {
                if ((this.FechaDespequeField.Equals(value) != true)) {
                    this.FechaDespequeField = value;
                    this.RaisePropertyChanged("FechaDespeque");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaLlegada {
            get {
                return this.FechaLlegadaField;
            }
            set {
                if ((this.FechaLlegadaField.Equals(value) != true)) {
                    this.FechaLlegadaField = value;
                    this.RaisePropertyChanged("FechaLlegada");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genero {
            get {
                return this.GeneroField;
            }
            set {
                if ((object.ReferenceEquals(this.GeneroField, value) != true)) {
                    this.GeneroField = value;
                    this.RaisePropertyChanged("Genero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LugarDestino {
            get {
                return this.LugarDestinoField;
            }
            set {
                if ((object.ReferenceEquals(this.LugarDestinoField, value) != true)) {
                    this.LugarDestinoField = value;
                    this.RaisePropertyChanged("LugarDestino");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LugarOrigen {
            get {
                return this.LugarOrigenField;
            }
            set {
                if ((object.ReferenceEquals(this.LugarOrigenField, value) != true)) {
                    this.LugarOrigenField = value;
                    this.RaisePropertyChanged("LugarOrigen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nacionalidad {
            get {
                return this.NacionalidadField;
            }
            set {
                if ((object.ReferenceEquals(this.NacionalidadField, value) != true)) {
                    this.NacionalidadField = value;
                    this.RaisePropertyChanged("Nacionalidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomPasajero {
            get {
                return this.NomPasajeroField;
            }
            set {
                if ((object.ReferenceEquals(this.NomPasajeroField, value) != true)) {
                    this.NomPasajeroField = value;
                    this.RaisePropertyChanged("NomPasajero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumTelefono {
            get {
                return this.NumTelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.NumTelefonoField, value) != true)) {
                    this.NumTelefonoField = value;
                    this.RaisePropertyChanged("NumTelefono");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyHistorialPasajero.IServicioHistorialPasajero")]
    public interface IServicioHistorialPasajero {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialPasajero/GetAllHistorialPasajero", ReplyAction="http://tempuri.org/IServicioHistorialPasajero/GetAllHistorialPasajeroResponse")]
        System.Collections.Generic.List<ClienteMVC.ProxyHistorialPasajero.Pasajero> GetAllHistorialPasajero();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialPasajero/GetAllHistorialPasajero", ReplyAction="http://tempuri.org/IServicioHistorialPasajero/GetAllHistorialPasajeroResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ClienteMVC.ProxyHistorialPasajero.Pasajero>> GetAllHistorialPasajeroAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialPasajero/GetHistorialPasajeroXNombrePasajero" +
            "", ReplyAction="http://tempuri.org/IServicioHistorialPasajero/GetHistorialPasajeroXNombrePasajero" +
            "Response")]
        System.Collections.Generic.List<ClienteMVC.ProxyHistorialPasajero.Pasajero> GetHistorialPasajeroXNombrePasajero(string nomPasajero, System.DateTime fecIni, System.DateTime fecFin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialPasajero/GetHistorialPasajeroXNombrePasajero" +
            "", ReplyAction="http://tempuri.org/IServicioHistorialPasajero/GetHistorialPasajeroXNombrePasajero" +
            "Response")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ClienteMVC.ProxyHistorialPasajero.Pasajero>> GetHistorialPasajeroXNombrePasajeroAsync(string nomPasajero, System.DateTime fecIni, System.DateTime fecFin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialPasajero/GetHistorialPasajeroXDNI", ReplyAction="http://tempuri.org/IServicioHistorialPasajero/GetHistorialPasajeroXDNIResponse")]
        System.Collections.Generic.List<ClienteMVC.ProxyHistorialPasajero.Pasajero> GetHistorialPasajeroXDNI(string dni, System.DateTime fecIni, System.DateTime fecFin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialPasajero/GetHistorialPasajeroXDNI", ReplyAction="http://tempuri.org/IServicioHistorialPasajero/GetHistorialPasajeroXDNIResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ClienteMVC.ProxyHistorialPasajero.Pasajero>> GetHistorialPasajeroXDNIAsync(string dni, System.DateTime fecIni, System.DateTime fecFin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialPasajero/GetCantidadVuelosXPasajero", ReplyAction="http://tempuri.org/IServicioHistorialPasajero/GetCantidadVuelosXPasajeroResponse")]
        System.Collections.Generic.List<ClienteMVC.ProxyHistorialPasajero.Pasajero> GetCantidadVuelosXPasajero(string codPasajero, System.DateTime fecIni, System.DateTime fecFin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioHistorialPasajero/GetCantidadVuelosXPasajero", ReplyAction="http://tempuri.org/IServicioHistorialPasajero/GetCantidadVuelosXPasajeroResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ClienteMVC.ProxyHistorialPasajero.Pasajero>> GetCantidadVuelosXPasajeroAsync(string codPasajero, System.DateTime fecIni, System.DateTime fecFin);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioHistorialPasajeroChannel : ClienteMVC.ProxyHistorialPasajero.IServicioHistorialPasajero, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioHistorialPasajeroClient : System.ServiceModel.ClientBase<ClienteMVC.ProxyHistorialPasajero.IServicioHistorialPasajero>, ClienteMVC.ProxyHistorialPasajero.IServicioHistorialPasajero {
        
        public ServicioHistorialPasajeroClient() {
        }
        
        public ServicioHistorialPasajeroClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioHistorialPasajeroClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioHistorialPasajeroClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioHistorialPasajeroClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<ClienteMVC.ProxyHistorialPasajero.Pasajero> GetAllHistorialPasajero() {
            return base.Channel.GetAllHistorialPasajero();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ClienteMVC.ProxyHistorialPasajero.Pasajero>> GetAllHistorialPasajeroAsync() {
            return base.Channel.GetAllHistorialPasajeroAsync();
        }
        
        public System.Collections.Generic.List<ClienteMVC.ProxyHistorialPasajero.Pasajero> GetHistorialPasajeroXNombrePasajero(string nomPasajero, System.DateTime fecIni, System.DateTime fecFin) {
            return base.Channel.GetHistorialPasajeroXNombrePasajero(nomPasajero, fecIni, fecFin);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ClienteMVC.ProxyHistorialPasajero.Pasajero>> GetHistorialPasajeroXNombrePasajeroAsync(string nomPasajero, System.DateTime fecIni, System.DateTime fecFin) {
            return base.Channel.GetHistorialPasajeroXNombrePasajeroAsync(nomPasajero, fecIni, fecFin);
        }
        
        public System.Collections.Generic.List<ClienteMVC.ProxyHistorialPasajero.Pasajero> GetHistorialPasajeroXDNI(string dni, System.DateTime fecIni, System.DateTime fecFin) {
            return base.Channel.GetHistorialPasajeroXDNI(dni, fecIni, fecFin);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ClienteMVC.ProxyHistorialPasajero.Pasajero>> GetHistorialPasajeroXDNIAsync(string dni, System.DateTime fecIni, System.DateTime fecFin) {
            return base.Channel.GetHistorialPasajeroXDNIAsync(dni, fecIni, fecFin);
        }
        
        public System.Collections.Generic.List<ClienteMVC.ProxyHistorialPasajero.Pasajero> GetCantidadVuelosXPasajero(string codPasajero, System.DateTime fecIni, System.DateTime fecFin) {
            return base.Channel.GetCantidadVuelosXPasajero(codPasajero, fecIni, fecFin);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ClienteMVC.ProxyHistorialPasajero.Pasajero>> GetCantidadVuelosXPasajeroAsync(string codPasajero, System.DateTime fecIni, System.DateTime fecFin) {
            return base.Channel.GetCantidadVuelosXPasajeroAsync(codPasajero, fecIni, fecFin);
        }
    }
}
