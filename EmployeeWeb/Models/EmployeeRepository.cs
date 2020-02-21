using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeWeb.Models;

namespace AspCoreApplication.Models
{
    public class EmployeeRepository: EmployeeManagement
    {
       public  List<Employee> elist;
        public EmployeeRepository() 
        {
            elist = new List<Employee>() { new Employee(1,"SK",Dept.Accounts),new Employee(2,"MS",Dept.Accounts), new Employee(2, "SM", Dept.IT) };
        }
        public Employee GetEmployee(int id1) 
        {
            Employee el = elist.FirstOrDefault(e => e.id == id1);
            //foreach(Employee x in e) 
            //{
            //    if (x.id == id)
            //        return x;
            //}
            return el;
        }
        public List<Employee> DisplayDetails()
        {
            return elist;
            //throw new NotImplementedException();
        }
        public bool AddEmployee(Employee emp) 
        {
            emp.id = elist.Max(e => e.id) + 1;
            elist.Add(emp);
            return true;
        }
    }
}
