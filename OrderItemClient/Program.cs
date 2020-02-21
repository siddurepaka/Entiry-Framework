using System;
using AssignmentOrdersItems;
using AssignmentOrdersItems.Models;
using AssignmentOrdersItems.Context;

namespace OrderItemClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {
                items i = new items() { ItemName = "SunGlasses", ItemPrice = 1200 };
                db.Add(i);
                db.SaveChanges();

            }
        }
    }
}
