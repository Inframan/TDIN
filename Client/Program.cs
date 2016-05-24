using System;
using System.ServiceModel;
using Client.InterBank;
using Client.BankA;
using Client.BankB;
using System.Collections.Generic;

namespace Client
{
    class Program
    {
        private static InterBankOpsClient proxy;
        static void Main(string[] args)
        {

            string company = "Apple Inc.";
            int quantity = 80;
            string username = "Gabriel Souto";
            string email = "gabrielsouto100d@gmail.com";
            DateTime request_date_time = DateTime.Now;
            string execution_value = "Request";
            string order_type = "Purchase";

            proxy = new InterBankOpsClient();

            if (proxy.State == CommunicationState.Opened)
                proxy.Close();
            Console.WriteLine("Press <Enter> to terminate.");
            Console.ReadLine();
        }


        public List<string> GetCompanies()
        {

            return proxy.GetCompanies();
        }


        public void PurchaseOrder(string company, int quantity, string username, string email, DateTime request_date_time, string execution_value, string order_type)
        {
            //    Console.WriteLine("Before: BankA balance = {0:F2}  BankB balance = {1:F2}",  bankAProxy.GetBalance(acctA), bankBProxy.GetBalance(acctB));
            Console.WriteLine("Purchasing: " + company + " whith: " + quantity.ToString("F2"));
            try
            {
                proxy.PurchaseStock(company, quantity, username, email, request_date_time, execution_value, order_type);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaction Aborted: " + ex.Message);
            }
            //Console.WriteLine("After: BankA balance = {0:F2}  BankB balance = {1:F2}",                        bankAProxy.GetBalance(acctA), bankBProxy.GetBalance(acctB));
            if (proxy.State == CommunicationState.Opened)
                proxy.Close();
        }



    }
}
