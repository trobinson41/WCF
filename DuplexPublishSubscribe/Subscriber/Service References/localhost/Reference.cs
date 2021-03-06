﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Subscriber.localhost {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.deccansoft.com/", ConfigurationName="localhost.IPublisherService", CallbackContract=typeof(Subscriber.localhost.IPublisherServiceCallback))]
    public interface IPublisherService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.deccansoft.com/IPublisherService/Subscribe", ReplyAction="http://www.deccansoft.com/IPublisherService/SubscribeResponse")]
        void Subscribe(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.deccansoft.com/IPublisherService/Unsubscribe", ReplyAction="http://www.deccansoft.com/IPublisherService/UnsubscribeResponse")]
        void Unsubscribe(System.Guid id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPublisherServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.deccansoft.com/IPublisherService/Notify")]
        void Notify(System.Guid id, System.DateTime time);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPublisherServiceChannel : Subscriber.localhost.IPublisherService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PublisherServiceClient : System.ServiceModel.DuplexClientBase<Subscriber.localhost.IPublisherService>, Subscriber.localhost.IPublisherService {
        
        public PublisherServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public PublisherServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public PublisherServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PublisherServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PublisherServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Subscribe(System.Guid id) {
            base.Channel.Subscribe(id);
        }
        
        public void Unsubscribe(System.Guid id) {
            base.Channel.Unsubscribe(id);
        }
    }
}
