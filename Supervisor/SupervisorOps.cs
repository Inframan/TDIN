using System;
using System.ServiceModel;

namespace Supervisor {
  public class SupervisorOps : ISupervisorOps {
    [OperationBehavior(TransactionScopeRequired=true)]
    public void ReportToSupervisor(string message) {
      Console.WriteLine(message);
    }
  }
}
