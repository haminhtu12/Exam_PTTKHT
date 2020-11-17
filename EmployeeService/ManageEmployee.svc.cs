using EmployeeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ManageEmployee" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ManageEmployee.svc or ManageEmployee.svc.cs at the Solution Explorer and start debugging.
    public class ManageEmployee : IManageEmployee
    {
        EmployeeDbContext db = new EmployeeDbContext();
        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }
        public bool AddEmployee(Employee ep, string name, string salary, string department)
        {
            try
            {
                    db.Employees.Add(ep);
                    db.SaveChanges();
                    return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Employee> GetEmployeeByDepartment(string department)
        {
          
                var ep = db.Employees.Where(x => x.Department == department).ToList();
                return ep;
           
        }
    }
}
