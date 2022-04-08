using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Employee
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmpService" in both code and config file together.
    [ServiceContract]
    public interface IEmpService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/EmpPayBill/{EmpPayId}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string EmpPayBill(string EmpPayId);
    }
}
