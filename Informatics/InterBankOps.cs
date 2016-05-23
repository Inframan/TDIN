using System;
using System.ServiceModel;
using Server.BankA;
using Server.BankB;
using Server.Supervisor;

namespace InterBank
{
    public class InterBankOps : IInterBankOps
    {
        SupervisorOpsClient supervisor = new SupervisorOpsClient();

        [OperationBehavior(TransactionScopeRequired = true)]
        void IInterBankOps.PurchaseStock(string company, double amount)
        {
            //string message = String.Format("Transfer of {0:F2} from A{1} to B{2}", amount, acctA, acctB);
            Console.WriteLine("Sucucessu!");
            supervisor.PurchaseStock(company, amount);
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        void IInterBankOps.SellStock(string company, double amount)
        {
           // string message = String.Format("Transfer of {0:F2} from B{1} to A{2}", amount, acctB, acctA);
            supervisor.SellStock(company,amount);
        }
    }
}
