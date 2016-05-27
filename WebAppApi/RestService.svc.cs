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


        public void PurchaseStock(Entity request)
        {
            o.PurchaseStock(request.company, request.quantity, request.username, request.email, request.request_date_time, request.execution_value, request.order_type);
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