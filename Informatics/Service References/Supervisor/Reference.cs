﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server.Supervisor {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Supervisor.ISupervisorOps")]
    public interface ISupervisorOps {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ISupervisorOps/PurchaseStock")]
        void PurchaseStock(string company, double amount);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/ISupervisorOps/SellStock")]
        void SellStock(string company, double amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISupervisorOpsChannel : Server.Supervisor.ISupervisorOps, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SupervisorOpsClient : System.ServiceModel.ClientBase<Server.Supervisor.ISupervisorOps>, Server.Supervisor.ISupervisorOps {
        
        public SupervisorOpsClient() {
        }
        
        public SupervisorOpsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SupervisorOpsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SupervisorOpsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SupervisorOpsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void PurchaseStock(string company, double amount) {
            base.Channel.PurchaseStock(company,amount);
        }

        public void SellStock(string company, double amount)
        {
            base.Channel.SellStock(company, amount);
        }
    }
}
