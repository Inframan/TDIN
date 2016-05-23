using System;
using System.ServiceModel;

namespace Supervisor
{
    public class SupervisorOps : ISupervisorOps
    {
        [OperationBehavior(TransactionScopeRequired = true)]
        public void PurhcaseStock(string company, double amount)
        {
            Console.WriteLine("Purchasing: " + company + " for: " + amount);
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void SellStock(string company, double amount)
        {
            Console.WriteLine("Selling: " + company + " for: "+amount);
        }
    }
}
