﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server.BankA {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BankA.IBankAOps", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IBankAOps {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankAOps/Deposit", ReplyAction="http://tempuri.org/IBankAOps/DepositResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        void Deposit(int acct, double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankAOps/Withdraw", ReplyAction="http://tempuri.org/IBankAOps/WithdrawResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        void Withdraw(int acct, double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankAOps/GetBalance", ReplyAction="http://tempuri.org/IBankAOps/GetBalanceResponse")]
        double GetBalance(int acct);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBankAOpsChannel : Server.BankA.IBankAOps, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BankAOpsClient : System.ServiceModel.ClientBase<Server.BankA.IBankAOps>, Server.BankA.IBankAOps {
        
        public BankAOpsClient() {
        }
        
        public BankAOpsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BankAOpsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankAOpsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankAOpsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Deposit(int acct, double amount) {
            base.Channel.Deposit(acct, amount);
        }
        
        public void Withdraw(int acct, double amount) {
            base.Channel.Withdraw(acct, amount);
        }
        
        public double GetBalance(int acct) {
            return base.Channel.GetBalance(acct);
        }
    }
}
