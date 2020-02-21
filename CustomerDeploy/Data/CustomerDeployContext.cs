using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerDeploy.Models;

namespace CustomerDeploy.Data
{
    public class CustomerDeployContext : DbContext
    {
        public CustomerDeployContext (DbContextOptions<CustomerDeployContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerDeploy.Models.Customer> Customer { get; set; }
    }
}
