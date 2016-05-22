using System;
using System.ServiceModel;

namespace ServerB {
  class Program {
    static void Main(string[] args) {
      ServiceHost host = new ServiceHost(typeof(BankB.BankBOps));
      host.Open();
      Console.WriteLine("Service BankB Active. Press <Enter> to close.");
      Console.ReadLine();
      host.Close();
    }
  }
}
