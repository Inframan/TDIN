using System;
using System.ServiceModel;

namespace InterBank {
  [ServiceContract(SessionMode=SessionMode.Required)]
  public interface IInterBankOps {

    [OperationContract]
    [TransactionFlow(TransactionFlowOption.Allowed)]
    void PurhcaseStock(string company, double amount);

    [OperationContract]
    [TransactionFlow(TransactionFlowOption.Allowed)]
    void SellStock(string company, double amount);
    }
}
