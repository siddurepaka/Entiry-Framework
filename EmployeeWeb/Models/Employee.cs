using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWeb.Models
{
    public class Employee
    {
            public int id { get; set; }
            public string name { get; set; }
            public Dept Dept { get; set; }
            public Employee(int i, string n, Dept d)
            {
                this.id = i;
                this.name = n;
                this.Dept = d;
            }
    } 
}
