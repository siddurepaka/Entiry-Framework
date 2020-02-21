using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using AssignmentOrdersItems.Models;
using AssignmentOrdersItems.Context;

namespace AssignmentOrdersItems.Context
{
   public class MyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2BPKC13\SQLEXPRESS;Initial Catalog=AssignmentDB;Persist Security Info=True;User ID=sa;Password=pass@word1");

        }
        public DbSet<Orders> orders { get; set; }
        public DbSet<items> items { get; set; }

    }
}
