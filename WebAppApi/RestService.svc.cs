using System;
using System.Collections.Generic;
using WebAppApi;
using WebAppApi.InterBank;

namespace RestService
{
    public class RestService : IService1
    {
        InterBankOpsClient o;
        public RestService()
        {
            o = new InterBankOpsClient();
        }


        public void PurchaseStock(string company, int quantity, string username, string email, DateTime request_date_time, string execution_value, string order_type)
        {
            o.PurchaseStock(company, quantity, username, email, request_date_time, execution_value, order_type);
        }

        public string[] GetCompanies()
        {
            return o.GetCompanies();
        }

        public string[][] GetOrders(string name, string mail)
        {
            return o.GetOrders(name, mail);
        }
    }
}