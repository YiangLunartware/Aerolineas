﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteASP.ProxyVuelos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Vuelos", Namespace="http://schemas.datacontract.org/2004/07/AirlineServices")]
    [System.SerializableAttribute()]
    public partial class Vuelos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CapacidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodAvionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodRutaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodVueloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DemandaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescVueloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EstadoVueloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FecDespegueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FecLlegadaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan HoraDespegueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan HoraLlegadaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomRutaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PrecioVueloField;
        
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
        public int Capacidad {
            get {
                return this.CapacidadField;
            }
            set {
                if ((this.CapacidadField.Equals(value) != true)) {
                    this.CapacidadField = value;
                    this.RaisePropertyChanged("Capacidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodAvion {
            get {
                return this.CodAvionField;
            }
            set {
                if ((object.ReferenceEquals(this.CodAvionField, value) != true)) {
                    this.CodAvionField = value;
                    this.RaisePropertyChanged("CodAvion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodRuta {
            get {
                return this.CodRutaField;
            }
            set {
                if ((object.ReferenceEquals(this.CodRutaField, value) != true)) {
                    this.CodRutaField = value;
                    this.RaisePropertyChanged("CodRuta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodVuelo {
            get {
                return this.CodVueloField;
            }
            set {
                if ((object.ReferenceEquals(this.CodVueloField, value) != true)) {
                    this.CodVueloField = value;
                    this.RaisePropertyChanged("CodVuelo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Demanda {
            get {
                return this.DemandaField;
            }
            set {
                if ((this.DemandaField.Equals(value) != true)) {
                    this.DemandaField = value;
                    this.RaisePropertyChanged("Demanda");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescVuelo {
            get {
                return this.DescVueloField;
            }
            set {
                if ((object.ReferenceEquals(this.DescVueloField, value) != true)) {
                    this.DescVueloField = value;
                    this.RaisePropertyChanged("DescVuelo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool EstadoVuelo {
            get {
                return this.EstadoVueloField;
            }
            set {
                if ((this.EstadoVueloField.Equals(value) != true)) {
                    this.EstadoVueloField = value;
                    this.RaisePropertyChanged("EstadoVuelo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FecDespegue {
            get {
                return this.FecDespegueField;
            }
            set {
                if ((this.FecDespegueField.Equals(value) != true)) {
                    this.FecDespegueField = value;
                    this.RaisePropertyChanged("FecDespegue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FecLlegada {
            get {
                return this.FecLlegadaField;
            }
            set {
                if ((this.FecLlegadaField.Equals(value) != true)) {
                    this.FecLlegadaField = value;
                    this.RaisePropertyChanged("FecLlegada");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan HoraDespegue {
            get {
                return this.HoraDespegueField;
            }
            set {
                if ((this.HoraDespegueField.Equals(value) != true)) {
                    this.HoraDespegueField = value;
                    this.RaisePropertyChanged("HoraDespegue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan HoraLlegada {
            get {
                return this.HoraLlegadaField;
            }
            set {
                if ((this.HoraLlegadaField.Equals(value) != true)) {
                    this.HoraLlegadaField = value;
                    this.RaisePropertyChanged("HoraLlegada");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomRuta {
            get {
                return this.NomRutaField;
            }
            set {
                if ((object.ReferenceEquals(this.NomRutaField, value) != true)) {
                    this.NomRutaField = value;
                    this.RaisePropertyChanged("NomRuta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal PrecioVuelo {
            get {
                return this.PrecioVueloField;
            }
            set {
                if ((this.PrecioVueloField.Equals(value) != true)) {
                    this.PrecioVueloField = value;
                    this.RaisePropertyChanged("PrecioVuelo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyVuelos.IServicioVuelos")]
    public interface IServicioVuelos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaVueloXDescipcion", ReplyAction="http://tempuri.org/IServicioVuelos/ListaVueloXDescipcionResponse")]
        ClienteASP.ProxyVuelos.Vuelos[] ListaVueloXDescipcion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaVueloXDescipcion", ReplyAction="http://tempuri.org/IServicioVuelos/ListaVueloXDescipcionResponse")]
        System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaVueloXDescipcionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaPrecios", ReplyAction="http://tempuri.org/IServicioVuelos/ListaPreciosResponse")]
        ClienteASP.ProxyVuelos.Vuelos[] ListaPrecios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaPrecios", ReplyAction="http://tempuri.org/IServicioVuelos/ListaPreciosResponse")]
        System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaPreciosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaAvionCapacidad", ReplyAction="http://tempuri.org/IServicioVuelos/ListaAvionCapacidadResponse")]
        ClienteASP.ProxyVuelos.Vuelos[] ListaAvionCapacidad();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaAvionCapacidad", ReplyAction="http://tempuri.org/IServicioVuelos/ListaAvionCapacidadResponse")]
        System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaAvionCapacidadAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaVueloPorDescripcion", ReplyAction="http://tempuri.org/IServicioVuelos/ListaVueloPorDescripcionResponse")]
        ClienteASP.ProxyVuelos.Vuelos[] ListaVueloPorDescripcion(string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaVueloPorDescripcion", ReplyAction="http://tempuri.org/IServicioVuelos/ListaVueloPorDescripcionResponse")]
        System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaVueloPorDescripcionAsync(string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaVueloPorEstado", ReplyAction="http://tempuri.org/IServicioVuelos/ListaVueloPorEstadoResponse")]
        ClienteASP.ProxyVuelos.Vuelos[] ListaVueloPorEstado(bool estado, System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaVueloPorEstado", ReplyAction="http://tempuri.org/IServicioVuelos/ListaVueloPorEstadoResponse")]
        System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaVueloPorEstadoAsync(bool estado, System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaVueloPorFecha", ReplyAction="http://tempuri.org/IServicioVuelos/ListaVueloPorFechaResponse")]
        ClienteASP.ProxyVuelos.Vuelos[] ListaVueloPorFecha(System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaVueloPorFecha", ReplyAction="http://tempuri.org/IServicioVuelos/ListaVueloPorFechaResponse")]
        System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaVueloPorFechaAsync(System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaVueloPorPrecio", ReplyAction="http://tempuri.org/IServicioVuelos/ListaVueloPorPrecioResponse")]
        ClienteASP.ProxyVuelos.Vuelos[] ListaVueloPorPrecio(decimal precio, System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaVueloPorPrecio", ReplyAction="http://tempuri.org/IServicioVuelos/ListaVueloPorPrecioResponse")]
        System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaVueloPorPrecioAsync(decimal precio, System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaVuelosPorCapacidad", ReplyAction="http://tempuri.org/IServicioVuelos/ListaVuelosPorCapacidadResponse")]
        ClienteASP.ProxyVuelos.Vuelos[] ListaVuelosPorCapacidad(int capacidad, System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaVuelosPorCapacidad", ReplyAction="http://tempuri.org/IServicioVuelos/ListaVuelosPorCapacidadResponse")]
        System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaVuelosPorCapacidadAsync(int capacidad, System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaCantidadVuelosFechas", ReplyAction="http://tempuri.org/IServicioVuelos/ListaCantidadVuelosFechasResponse")]
        ClienteASP.ProxyVuelos.Vuelos[] ListaCantidadVuelosFechas(System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVuelos/ListaCantidadVuelosFechas", ReplyAction="http://tempuri.org/IServicioVuelos/ListaCantidadVuelosFechasResponse")]
        System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaCantidadVuelosFechasAsync(System.DateTime fecini, System.DateTime fecfin);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioVuelosChannel : ClienteASP.ProxyVuelos.IServicioVuelos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioVuelosClient : System.ServiceModel.ClientBase<ClienteASP.ProxyVuelos.IServicioVuelos>, ClienteASP.ProxyVuelos.IServicioVuelos {
        
        public ServicioVuelosClient() {
        }
        
        public ServicioVuelosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioVuelosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioVuelosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioVuelosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClienteASP.ProxyVuelos.Vuelos[] ListaVueloXDescipcion() {
            return base.Channel.ListaVueloXDescipcion();
        }
        
        public System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaVueloXDescipcionAsync() {
            return base.Channel.ListaVueloXDescipcionAsync();
        }
        
        public ClienteASP.ProxyVuelos.Vuelos[] ListaPrecios() {
            return base.Channel.ListaPrecios();
        }
        
        public System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaPreciosAsync() {
            return base.Channel.ListaPreciosAsync();
        }
        
        public ClienteASP.ProxyVuelos.Vuelos[] ListaAvionCapacidad() {
            return base.Channel.ListaAvionCapacidad();
        }
        
        public System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaAvionCapacidadAsync() {
            return base.Channel.ListaAvionCapacidadAsync();
        }
        
        public ClienteASP.ProxyVuelos.Vuelos[] ListaVueloPorDescripcion(string descripcion) {
            return base.Channel.ListaVueloPorDescripcion(descripcion);
        }
        
        public System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaVueloPorDescripcionAsync(string descripcion) {
            return base.Channel.ListaVueloPorDescripcionAsync(descripcion);
        }
        
        public ClienteASP.ProxyVuelos.Vuelos[] ListaVueloPorEstado(bool estado, System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.ListaVueloPorEstado(estado, fecini, fecfin);
        }
        
        public System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaVueloPorEstadoAsync(bool estado, System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.ListaVueloPorEstadoAsync(estado, fecini, fecfin);
        }
        
        public ClienteASP.ProxyVuelos.Vuelos[] ListaVueloPorFecha(System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.ListaVueloPorFecha(fecini, fecfin);
        }
        
        public System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaVueloPorFechaAsync(System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.ListaVueloPorFechaAsync(fecini, fecfin);
        }
        
        public ClienteASP.ProxyVuelos.Vuelos[] ListaVueloPorPrecio(decimal precio, System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.ListaVueloPorPrecio(precio, fecini, fecfin);
        }
        
        public System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaVueloPorPrecioAsync(decimal precio, System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.ListaVueloPorPrecioAsync(precio, fecini, fecfin);
        }
        
        public ClienteASP.ProxyVuelos.Vuelos[] ListaVuelosPorCapacidad(int capacidad, System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.ListaVuelosPorCapacidad(capacidad, fecini, fecfin);
        }
        
        public System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaVuelosPorCapacidadAsync(int capacidad, System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.ListaVuelosPorCapacidadAsync(capacidad, fecini, fecfin);
        }
        
        public ClienteASP.ProxyVuelos.Vuelos[] ListaCantidadVuelosFechas(System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.ListaCantidadVuelosFechas(fecini, fecfin);
        }
        
        public System.Threading.Tasks.Task<ClienteASP.ProxyVuelos.Vuelos[]> ListaCantidadVuelosFechasAsync(System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.ListaCantidadVuelosFechasAsync(fecini, fecfin);
        }
    }
}
