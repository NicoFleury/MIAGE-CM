﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MIAGE.Exemple.Client.PaysService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pays", Namespace="http://schemas.datacontract.org/2004/07/MIAGE.Exemple.WCF.DataContract")]
    [System.SerializableAttribute()]
    public partial class Pays : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PaysService.IPaysService")]
    public interface IPaysService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaysService/GetAllPAys", ReplyAction="http://tempuri.org/IPaysService/GetAllPAysResponse")]
        System.Collections.Generic.List<MIAGE.Exemple.Client.PaysService.Pays> GetAllPAys();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaysService/GetAllPAys", ReplyAction="http://tempuri.org/IPaysService/GetAllPAysResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MIAGE.Exemple.Client.PaysService.Pays>> GetAllPAysAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaysService/GetPaysById", ReplyAction="http://tempuri.org/IPaysService/GetPaysByIdResponse")]
        MIAGE.Exemple.Client.PaysService.Pays GetPaysById(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaysService/GetPaysById", ReplyAction="http://tempuri.org/IPaysService/GetPaysByIdResponse")]
        System.Threading.Tasks.Task<MIAGE.Exemple.Client.PaysService.Pays> GetPaysByIdAsync(long id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPaysServiceChannel : MIAGE.Exemple.Client.PaysService.IPaysService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PaysServiceClient : System.ServiceModel.ClientBase<MIAGE.Exemple.Client.PaysService.IPaysService>, MIAGE.Exemple.Client.PaysService.IPaysService {
        
        public PaysServiceClient() {
        }
        
        public PaysServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PaysServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaysServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaysServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<MIAGE.Exemple.Client.PaysService.Pays> GetAllPAys() {
            return base.Channel.GetAllPAys();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MIAGE.Exemple.Client.PaysService.Pays>> GetAllPAysAsync() {
            return base.Channel.GetAllPAysAsync();
        }
        
        public MIAGE.Exemple.Client.PaysService.Pays GetPaysById(long id) {
            return base.Channel.GetPaysById(id);
        }
        
        public System.Threading.Tasks.Task<MIAGE.Exemple.Client.PaysService.Pays> GetPaysByIdAsync(long id) {
            return base.Channel.GetPaysByIdAsync(id);
        }
    }
}