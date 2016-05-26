using System;
using System.Collections.Generic;
using System.ServiceModel;


namespace InterBank
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IInterBankOps
    {

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void PurchaseStock(string company, int quantity, string username, string email, DateTime request_date_time, string execution_value, string order_type);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        List<String> GetCompanies();

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        List<string[]> GetOrders(string client_name, string client_id);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void UpdateOrder(int order_id,DateTime execution_date, string execution_status, string execution_value);

    }
}
