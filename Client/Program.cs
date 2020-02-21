using System;
using EFCODEDBFIRST1.Models;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using(AssignmentDBContext db=new AssignmentDBContext())
            {
                Items i = new Items() { ItemName = "honor" ,ItemPrice=9999};
                db.Add(i);
                db.SaveChanges();
            }
        }
    }
}
