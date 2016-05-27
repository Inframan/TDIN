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
        [WebInvoke(Method = "POST", UriTemplate = "/purchaseStock", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        void PurchaseStock(string company, int quantity, string username, string email, DateTime request_date_time, string execution_value, string order_type);

        [WebGet(UriTemplate = "/companies", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        string[] GetCompanies();

        [WebInvoke(Method = "GET", UriTemplate = "/orders/{name}&{mail}", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        string[][] GetOrders(string name, string mail);

    }
   
}
