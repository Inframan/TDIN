using System;
using System.ServiceModel;
using Client.InterBank;
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

            Program p = new Program();

            List<string[]> orders = p.GetOrders(username, email);
            

            foreach (string[] o in orders)
            {
                Order orderclass = new Order(o[0], o[1], o[2], o[3], o[4], o[5], o[6]);
            }

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

        public List<string[]> GetOrders(string client_name, string client_email)
        {
            return proxy.GetOrders(client_name, client_email);
        }


    }
}
