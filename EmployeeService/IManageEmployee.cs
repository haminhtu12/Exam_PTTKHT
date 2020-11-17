using EmployeeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IManageEmployee" in both code and config file together.
    [ServiceContract]
    public interface IManageEmployee
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
              RequestFormat = WebMessageFormat.Json,
              ResponseFormat = WebMessageFormat.Json,
               BodyStyle = WebMessageBodyStyle.Bare,
              UriTemplate = "api/v1/GetEmployeeList")]
        List<Employee> GetEmployees();

        [WebInvoke(Method = "POST",
     RequestFormat = WebMessageFormat.Json,
     ResponseFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "api/v1/CreateEmployee")]
        bool AddEmployee(Employee ep, string name, string salary , string department);
        
        [WebInvoke(Method = "GET",
     RequestFormat = WebMessageFormat.Json,
     ResponseFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Bare,
     UriTemplate = "api/v1/SearchEmployee")]
      IEnumerable<Employee>  GetEmployeeByDepartment(string department);
    }

}
