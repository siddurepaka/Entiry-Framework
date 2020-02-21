using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EFDAL.Models;
namespace EFDAL.Context
{
   public  class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2BPKC13\SQLEXPRESS;Initial Catalog=AssignmentDB;Persist Security Info=True;User ID=sa;Password=pass@word1");

        }
        public DbSet<Project> projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
