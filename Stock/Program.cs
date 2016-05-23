using System;
using System.ServiceModel;

namespace Supervisor {
  class Program {
    static void Main(string[] args) {
      ServiceHost host = new ServiceHost(typeof(Supervisor.SupervisorOps));
      host.Open();
      Console.WriteLine("Service Supervisor Active. Press <Enter> to close.");
      Console.ReadLine();
      host.Close();
    }
  }
}
