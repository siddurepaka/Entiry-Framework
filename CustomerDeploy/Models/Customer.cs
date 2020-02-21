using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerDeploy.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Emmail { get; set; }
        public int Account { get; set; }
        public Customer()
        {

        }
        public Customer(int id,string name,string email,int amt)
        {
            this.Id = id;
            this.Name = name;
            this.Emmail = email;
            this.Account = amt;
        }

    }
}
