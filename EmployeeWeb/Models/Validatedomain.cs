using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWeb.Models
{
    public class Validatedomain
    {
        public class Validatedomain : ValidationAttribute
        {
            private readonly string allowDomain;
            public Validatedomain(string allowdomain)
            {
                this.allowDomain = allowdomain;
            }
            public override bool IsValid(object value)
            {
                string[] email = value.ToString().Split('@');
                if (email[1] == this.allowDomain)
                    //return base.IsValid(value);
                    return true;
                else
                    return false;
            }
        }
}
