using System;
using EFDAL;
using EFDAL.Context;
using EFDAL.Models;


namespace EMS_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {
                Project p = new Project() { ProjectName = "BFS" };
                db.Add(p);
                db.SaveChanges();

            }
        }
    }
}
