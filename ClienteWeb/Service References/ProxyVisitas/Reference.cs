﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWeb.ProxyVisitas {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Visitas", Namespace="http://schemas.datacontract.org/2004/07/AirlineServices")]
    [System.SerializableAttribute()]
    public partial class Visitas : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ApellidoPasajeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoDestinoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaDespequeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaLlegadaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomRutaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreLugarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombrePasajeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RankingVisitasDestinosPeruanosField;
        
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
        public System.DateTime ApellidoPasajero {
            get {
                return this.ApellidoPasajeroField;
            }
            set {
                if ((this.ApellidoPasajeroField.Equals(value) != true)) {
                    this.ApellidoPasajeroField = value;
                    this.RaisePropertyChanged("ApellidoPasajero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoDestino {
            get {
                return this.CodigoDestinoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoDestinoField, value) != true)) {
                    this.CodigoDestinoField = value;
                    this.RaisePropertyChanged("CodigoDestino");
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
        public string NombreLugar {
            get {
                return this.NombreLugarField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreLugarField, value) != true)) {
                    this.NombreLugarField = value;
                    this.RaisePropertyChanged("NombreLugar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombrePasajero {
            get {
                return this.NombrePasajeroField;
            }
            set {
                if ((object.ReferenceEquals(this.NombrePasajeroField, value) != true)) {
                    this.NombrePasajeroField = value;
                    this.RaisePropertyChanged("NombrePasajero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RankingVisitasDestinosPeruanos {
            get {
                return this.RankingVisitasDestinosPeruanosField;
            }
            set {
                if ((this.RankingVisitasDestinosPeruanosField.Equals(value) != true)) {
                    this.RankingVisitasDestinosPeruanosField = value;
                    this.RaisePropertyChanged("RankingVisitasDestinosPeruanos");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyVisitas.IServicioVisitas")]
    public interface IServicioVisitas {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVisitas/GetVisitas_X_Fecha", ReplyAction="http://tempuri.org/IServicioVisitas/GetVisitas_X_FechaResponse")]
        ClienteWeb.ProxyVisitas.Visitas[] GetVisitas_X_Fecha(System.DateTime fechaInicial, System.DateTime fechaFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVisitas/GetVisitas_X_Fecha", ReplyAction="http://tempuri.org/IServicioVisitas/GetVisitas_X_FechaResponse")]
        System.Threading.Tasks.Task<ClienteWeb.ProxyVisitas.Visitas[]> GetVisitas_X_FechaAsync(System.DateTime fechaInicial, System.DateTime fechaFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVisitas/GetVisitas_X_LugarOrigen", ReplyAction="http://tempuri.org/IServicioVisitas/GetVisitas_X_LugarOrigenResponse")]
        ClienteWeb.ProxyVisitas.Visitas[] GetVisitas_X_LugarOrigen(string LugarOrigen, System.DateTime fechaInicial, System.DateTime fechaFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVisitas/GetVisitas_X_LugarOrigen", ReplyAction="http://tempuri.org/IServicioVisitas/GetVisitas_X_LugarOrigenResponse")]
        System.Threading.Tasks.Task<ClienteWeb.ProxyVisitas.Visitas[]> GetVisitas_X_LugarOrigenAsync(string LugarOrigen, System.DateTime fechaInicial, System.DateTime fechaFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVisitas/AllVisitas", ReplyAction="http://tempuri.org/IServicioVisitas/AllVisitasResponse")]
        ClienteWeb.ProxyVisitas.Visitas[] AllVisitas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVisitas/AllVisitas", ReplyAction="http://tempuri.org/IServicioVisitas/AllVisitasResponse")]
        System.Threading.Tasks.Task<ClienteWeb.ProxyVisitas.Visitas[]> AllVisitasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVisitas/RankingVisitasDestinosPeruanos", ReplyAction="http://tempuri.org/IServicioVisitas/RankingVisitasDestinosPeruanosResponse")]
        ClienteWeb.ProxyVisitas.Visitas[] RankingVisitasDestinosPeruanos(System.DateTime fechaLLegada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioVisitas/RankingVisitasDestinosPeruanos", ReplyAction="http://tempuri.org/IServicioVisitas/RankingVisitasDestinosPeruanosResponse")]
        System.Threading.Tasks.Task<ClienteWeb.ProxyVisitas.Visitas[]> RankingVisitasDestinosPeruanosAsync(System.DateTime fechaLLegada);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioVisitasChannel : ClienteWeb.ProxyVisitas.IServicioVisitas, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioVisitasClient : System.ServiceModel.ClientBase<ClienteWeb.ProxyVisitas.IServicioVisitas>, ClienteWeb.ProxyVisitas.IServicioVisitas {
        
        public ServicioVisitasClient() {
        }
        
        public ServicioVisitasClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioVisitasClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioVisitasClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioVisitasClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClienteWeb.ProxyVisitas.Visitas[] GetVisitas_X_Fecha(System.DateTime fechaInicial, System.DateTime fechaFinal) {
            return base.Channel.GetVisitas_X_Fecha(fechaInicial, fechaFinal);
        }
        
        public System.Threading.Tasks.Task<ClienteWeb.ProxyVisitas.Visitas[]> GetVisitas_X_FechaAsync(System.DateTime fechaInicial, System.DateTime fechaFinal) {
            return base.Channel.GetVisitas_X_FechaAsync(fechaInicial, fechaFinal);
        }
        
        public ClienteWeb.ProxyVisitas.Visitas[] GetVisitas_X_LugarOrigen(string LugarOrigen, System.DateTime fechaInicial, System.DateTime fechaFinal) {
            return base.Channel.GetVisitas_X_LugarOrigen(LugarOrigen, fechaInicial, fechaFinal);
        }
        
        public System.Threading.Tasks.Task<ClienteWeb.ProxyVisitas.Visitas[]> GetVisitas_X_LugarOrigenAsync(string LugarOrigen, System.DateTime fechaInicial, System.DateTime fechaFinal) {
            return base.Channel.GetVisitas_X_LugarOrigenAsync(LugarOrigen, fechaInicial, fechaFinal);
        }
        
        public ClienteWeb.ProxyVisitas.Visitas[] AllVisitas() {
            return base.Channel.AllVisitas();
        }
        
        public System.Threading.Tasks.Task<ClienteWeb.ProxyVisitas.Visitas[]> AllVisitasAsync() {
            return base.Channel.AllVisitasAsync();
        }
        
        public ClienteWeb.ProxyVisitas.Visitas[] RankingVisitasDestinosPeruanos(System.DateTime fechaLLegada) {
            return base.Channel.RankingVisitasDestinosPeruanos(fechaLLegada);
        }
        
        public System.Threading.Tasks.Task<ClienteWeb.ProxyVisitas.Visitas[]> RankingVisitasDestinosPeruanosAsync(System.DateTime fechaLLegada) {
            return base.Channel.RankingVisitasDestinosPeruanosAsync(fechaLLegada);
        }
    }
}