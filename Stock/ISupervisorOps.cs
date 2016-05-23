using System;
using System.ServiceModel;

namespace Supervisor
{
    [ServiceContract]
    public interface ISupervisorOps
    {

        [OperationContract(IsOneWay = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void PurchaseStock(string company, double amount);


        [OperationContract(IsOneWay = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void SellStock(string company, double amount);
    }
}
