using System;

namespace EFCoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {


           DemoContext dc = new DemoContext();

            Person ds = new Person()
            {
                // I'm not supplying a person ID at all

                FirstName = "Daniel",
                LastName = "Segan",
                HireDate = DateTime.Parse("10/17/2018"),
                MiddleInital = "J",
                SSN = "999-99-9999",
                TermDate = DateTime.Parse("1/1/2019")
            };

            Address dsHome = new Address { Line1 = "120 West End Ave.", City = "New York", State = "NY", zip = "10023" };
            Address dsWork= new Address { Line1 = "50 West End Ave.", City = "New York", State = "NY", zip = "10023" };

            ds.Addresses.Add(dsHome);
            ds.Addresses.Add(dsWork);
                    
            Person hg = new Person()
            {

                FirstName = "Hans",
                LastName = "Gruber",
                HireDate = DateTime.Parse("10/17/2018"),
                //MiddleInital = "J",
                SSN = "999-99-9999",
                TermDate = DateTime.Parse("1/1/2019")
            };


            dc.People.Add(ds);
            
            dc.SaveChanges();

            Console.WriteLine("Hit any key to continue.");
            Console.ReadKey();
        }
    }
}
