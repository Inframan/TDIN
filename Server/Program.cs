using System;
using System.ServiceModel;

namespace Server {
  class Program {
    static void Main(string[] args) {
      ServiceHost host = new ServiceHost(typeof(InterBank.InterBankOps));
      host.Open();
      Console.WriteLine("Service InterBank Active. Press <Enter> to close.");
      Console.ReadLine();
      host.Close();
    }
  }
}
