﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirstDemoAppClient.localhost {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Complex", Namespace="http://schemas.datacontract.org/2004/07/FirstDemoApp")]
    [System.SerializableAttribute()]
    public partial class Complex : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ImagField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RealField;
        
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
        public int Imag {
            get {
                return this.ImagField;
            }
            set {
                if ((this.ImagField.Equals(value) != true)) {
                    this.ImagField = value;
                    this.RaisePropertyChanged("Imag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Real {
            get {
                return this.RealField;
            }
            set {
                if ((this.RealField.Equals(value) != true)) {
                    this.RealField = value;
                    this.RaisePropertyChanged("Real");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="localhost.IMathService")]
    public interface IMathService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Add", ReplyAction="http://tempuri.org/IMathService/AddResponse")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Add", ReplyAction="http://tempuri.org/IMathService/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/AddComplex", ReplyAction="http://tempuri.org/IMathService/AddComplexResponse")]
        FirstDemoAppClient.localhost.Complex AddComplex(FirstDemoAppClient.localhost.Complex c1, FirstDemoAppClient.localhost.Complex c2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/AddComplex", ReplyAction="http://tempuri.org/IMathService/AddComplexResponse")]
        System.Threading.Tasks.Task<FirstDemoAppClient.localhost.Complex> AddComplexAsync(FirstDemoAppClient.localhost.Complex c1, FirstDemoAppClient.localhost.Complex c2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/GetCounter", ReplyAction="http://tempuri.org/IMathService/GetCounterResponse")]
        int GetCounter();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/GetCounter", ReplyAction="http://tempuri.org/IMathService/GetCounterResponse")]
        System.Threading.Tasks.Task<int> GetCounterAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMathServiceChannel : FirstDemoAppClient.localhost.IMathService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MathServiceClient : System.ServiceModel.ClientBase<FirstDemoAppClient.localhost.IMathService>, FirstDemoAppClient.localhost.IMathService {
        
        public MathServiceClient() {
        }
        
        public MathServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MathServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
        
        public FirstDemoAppClient.localhost.Complex AddComplex(FirstDemoAppClient.localhost.Complex c1, FirstDemoAppClient.localhost.Complex c2) {
            return base.Channel.AddComplex(c1, c2);
        }
        
        public System.Threading.Tasks.Task<FirstDemoAppClient.localhost.Complex> AddComplexAsync(FirstDemoAppClient.localhost.Complex c1, FirstDemoAppClient.localhost.Complex c2) {
            return base.Channel.AddComplexAsync(c1, c2);
        }
        
        public int GetCounter() {
            return base.Channel.GetCounter();
        }
        
        public System.Threading.Tasks.Task<int> GetCounterAsync() {
            return base.Channel.GetCounterAsync();
        }
    }
}
