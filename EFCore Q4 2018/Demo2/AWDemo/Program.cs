using System;
using AWDemo.Model;
using System.Linq;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace AWDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new AdventureContext())
            {
                //var orders = ctx.SalesOrderHeader.Include(so => so.SalesOrderDetail).ToList();

                var orders = ctx.SalesOrderHeader.AsNoTracking().Include(so => so.SalesOrderDetail).ToList();

                foreach (var o in orders)
                {
                    Console.WriteLine($"{o.SalesOrderDetail.Count}");
                }
            }

            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }
    }
}
