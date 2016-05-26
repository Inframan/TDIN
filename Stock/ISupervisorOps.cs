using System;
using System.ServiceModel;

namespace Supervisor
{
    [ServiceContract]
    public interface ISupervisorOps
    {

        [OperationContract(IsOneWay = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void PurchaseStock(int order_id,string company, int company_id, int quantity, string username, int client_id, DateTime request_date_time, string execution_value, string order_type);
        
    }
}
