using System;
using System.ServiceModel;
using Client.InterBank;
using Client.BankA;
using Client.BankB;

namespace Client {
  class Program {
    static void Main(string[] args) {
      int acctA = 121, acctB = 1004;
      double amount = 80.00;
      
      InterBankOpsClient proxy = new InterBankOpsClient();
      BankAOpsClient bankAProxy = new BankAOpsClient();
      BankBOpsClient bankBProxy = new BankBOpsClient();
      Console.WriteLine("Before: BankA balance = {0:F2}  BankB balance = {1:F2}",
                        bankAProxy.GetBalance(acctA), bankBProxy.GetBalance(acctB));
      Console.WriteLine("Doing a transfer (B to A) of {0:F2}", amount);
      try {
        proxy.TransferBtoA(acctB, acctA, amount);
      }
      catch (Exception ex) {
        Console.WriteLine("Transaction Aborted: " + ex.Message);
      }
      Console.WriteLine("After: BankA balance = {0:F2}  BankB balance = {1:F2}",
                        bankAProxy.GetBalance(acctA), bankBProxy.GetBalance(acctB));
      bankBProxy.Close();
      bankAProxy.Close();
      if (proxy.State == CommunicationState.Opened)
        proxy.Close();
      Console.WriteLine("Press <Enter> to terminate.");
      Console.ReadLine();
    }
  }
}
