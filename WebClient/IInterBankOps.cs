using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace WebClient
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

    }
}
