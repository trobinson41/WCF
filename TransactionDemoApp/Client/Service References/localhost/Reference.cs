﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.localhost {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="localhost.IAccoutService")]
    public interface IAccoutService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccoutService/Deposit", ReplyAction="http://tempuri.org/IAccoutService/DepositResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Mandatory)]
        void Deposit(int accountId, decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccoutService/Withdraw", ReplyAction="http://tempuri.org/IAccoutService/WithdrawResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Mandatory)]
        void Withdraw(int accountId, decimal amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IAccoutServiceChannel : Client.localhost.IAccoutService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class AccoutServiceClient : System.ServiceModel.ClientBase<Client.localhost.IAccoutService>, Client.localhost.IAccoutService {
        
        public AccoutServiceClient() {
        }
        
        public AccoutServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccoutServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccoutServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccoutServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Deposit(int accountId, decimal amount) {
            base.Channel.Deposit(accountId, amount);
        }
        
        public void Withdraw(int accountId, decimal amount) {
            base.Channel.Withdraw(accountId, amount);
        }
    }
}