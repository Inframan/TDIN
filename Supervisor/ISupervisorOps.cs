using System;
using System.ServiceModel;

namespace Supervisor {
  [ServiceContract]
  public interface ISupervisorOps {

    [OperationContract(IsOneWay=true)]
    [TransactionFlow(TransactionFlowOption.Allowed)]
    void ReportToSupervisor(string message);
  }
}
