using System;
using System.ServiceModel;
using Client.InterBank;
using Client.BankA;
using Client.BankB;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string company = "Apple Inc.";
            int quantity = 80;
            string username = "Gabriel Souto";
            string email = "gabrielsouto100d@gmail.com";
            DateTime request_date_time = DateTime.Now;
            string execution_value = "Request";

            InterBankOpsClient proxy = new InterBankOpsClient();
            //    Console.WriteLine("Before: BankA balance = {0:F2}  BankB balance = {1:F2}",  bankAProxy.GetBalance(acctA), bankBProxy.GetBalance(acctB));
            Console.WriteLine("Purchasing: " + company + " whith: " + quantity.ToString("F2"));
            try
            {
                proxy.PurchaseStock(company, quantity, username, email, request_date_time, execution_value);
            }
            catch (Exception ex)
            {
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
