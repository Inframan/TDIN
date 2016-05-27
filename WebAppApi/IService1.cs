using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebAppApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        //http://localhost:56173/RestService.svc/purchaseStock
        /*
        {"company" : "Foxconn", "email" : "gabrielsouto100d@gmail.com", "execution_value" : "",
 "order_type" : "Purchase", "quantity" : "5", 
"request_date_time":"\/Date(928146000000+0100)\/","username" : "Gabriel Souto"}
        */
        [WebInvoke(Method = "POST", UriTemplate = "/purchaseStock", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        void PurchaseStock(Entity request);


        //http://localhost:56173/RestService.svc/companies
        [WebGet(UriTemplate = "/companies", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        string[] GetCompanies();

        //http://localhost:56173/RestService.svc/orders/name=Gabriel%20Souto/mail=gabrielsouto100d@gmail.com
        [WebInvoke(Method = "GET", UriTemplate = "/orders/name={name}/mail={mail}", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        string[][] GetOrders(string name, string mail);

    }

    public class Entity
    {
        public string company;
        public int quantity;
        public string username;
        public string email;
        public DateTime request_date_time;
        public string execution_value;
        public string order_type;
    }
}
