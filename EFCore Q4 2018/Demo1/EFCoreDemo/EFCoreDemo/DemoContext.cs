using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo
{
    public class DemoContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            // Enable Logging
            var lf = new LoggerFactory();
            lf.AddProvider(new MyLoggerProvider());
            optionsBuilder.UseLoggerFactory(lf);

            // Turn this on to see the values of the query
            optionsBuilder.EnableSensitiveDataLogging(true);

            // This is our connection string to the DB
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Demo;Trusted_Connection=True;");
        }
    }
}
