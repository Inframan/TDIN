﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Stock.InterBank {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InterBank.IInterBankOps", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IInterBankOps {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IInterBankOps/PurchaseStock", ReplyAction = "http://tempuri.org/IInterBankOps/PurchaseStockResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        void PurchaseStock(string company, int quantity, string username, string email, DateTime request_date_time, string execution_value, string order_type);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IInterBankOps/GetCompanies", ReplyAction = "http://tempuri.org/IInterBankOps/GetCompaniesResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        List<String> GetCompanies();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IInterBankOps/GetOrders", ReplyAction = "http://tempuri.org/IInterBankOps/GetOrdersResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        List<string[]> GetOrders(string client_name,string client_mail);

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInterBankOpsChannel : Client.InterBank.IInterBankOps, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InterBankOpsClient : System.ServiceModel.ClientBase<Client.InterBank.IInterBankOps>, Client.InterBank.IInterBankOps {
        
        public InterBankOpsClient() {
        }
        
        public InterBankOpsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InterBankOpsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InterBankOpsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InterBankOpsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void PurchaseStock(string company, int quantity, string username, string email, DateTime request_date_time, string execution_value, string order_type) {
            base.Channel.PurchaseStock(company, quantity, username, email, request_date_time, execution_value, order_type);
        }

        public List<String> GetCompanies()
        {
            return base.Channel.GetCompanies();
        }

        public List<string[]> GetOrders(string client_name, string client_mail)
        {
            return base.Channel.GetOrders(client_name,client_mail);
        }

    }
}