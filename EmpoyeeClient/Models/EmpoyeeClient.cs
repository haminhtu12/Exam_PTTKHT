using EmpoyeeClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace EmpoyeeClient.Models
{
    public class EmpoyeeClient
    {
        ManageEmployeeClient client = new ManageEmployeeClient();
        public void addEmployee(Eployee ep, string name, string salary, string department)
        {
            var cm = new ServiceReference1.Employee
            {
                Id = ep.ID,
                Name = ep.Name,
                Salary = ep.Salary,
                Department = ep.Department,
            };
            client.AddEmployee(cm, name, salary, department);
        }
        public List<Eployee> searchEmployee(string department)
        {
            var listEp = client.GetEmployeeByDepartment(department);
            var cm = new List<Eployee>();
            listEp.ForEach(a => cm.Add(new Eployee()
            {
                
            }));
            return cm;
        }
    }
}