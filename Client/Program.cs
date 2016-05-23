using System;
using System.ServiceModel;
using Client.InterBank;
using Client.BankA;
using Client.BankB;

namespace Client {
  class Program {
    static void Main(string[] args) {
      string company = "Apple";
      double amount = 80.00;
      
      InterBankOpsClient proxy = new InterBankOpsClient();
            //    Console.WriteLine("Before: BankA balance = {0:F2}  BankB balance = {1:F2}",  bankAProxy.GetBalance(acctA), bankBProxy.GetBalance(acctB));
            Console.WriteLine("Purchasing: " + company+ " whith: " + amount.ToString("F2"));
      try {
        proxy.PurchaseStock(company, amount);
      }
      catch (Exception ex) {
        Console.WriteLine("Transaction Aborted: " + ex.Message);
      }
      //Console.WriteLine("After: BankA balance = {0:F2}  BankB balance = {1:F2}",                        bankAProxy.GetBalance(acctA), bankBProxy.GetBalance(acctB));
      if (proxy.State == CommunicationState.Opened)
        proxy.Close();
      Console.WriteLine("Press <Enter> to terminate.");
      Console.ReadLine();
    }
  }
}
