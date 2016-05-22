using System;
using System.ServiceModel;

namespace InterBank {
  [ServiceContract(SessionMode=SessionMode.Required)]
  public interface IInterBankOps {

    [OperationContract]
    [TransactionFlow(TransactionFlowOption.Allowed)]
    void TransferAtoB(int acctA, int acctB, double amount);

    [OperationContract]
    [TransactionFlow(TransactionFlowOption.Allowed)]
    void TransferBtoA(int acctB, int acctA, double amount);
  }
}
