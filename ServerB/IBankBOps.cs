using System;
using System.ServiceModel;

namespace BankB {
  [ServiceContract(SessionMode=SessionMode.Required)]
  public interface IBankBOps {

    [OperationContract]
    [TransactionFlow(TransactionFlowOption.Allowed)]
    void Deposit(int acct, double amount);

    [OperationContract]
    [TransactionFlow(TransactionFlowOption.Allowed)]
    void Withdraw(int acct, double amount);

    [OperationContract]
    double GetBalance(int acct);
  }
}
