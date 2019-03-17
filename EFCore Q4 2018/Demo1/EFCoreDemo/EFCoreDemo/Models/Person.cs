using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo
{
    public class Person
    {
        // Initial version of my class.
        // Looks OK at first, but has some fundamental issues. 
        
        // Do we really need this?
        public int PersonId { get; set; }
        // Could this be a key?
        public string SSN { get; set; }      
        public string FirstName { get; set; }
        // Do I really need this to be supplied? 
        public string MiddleInital { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        // What about people who are terminated. 
        public DateTime TermDate { get; set; }                  
        public List<Address> Addresses { get; set; }

        public string JobTitle { get; set; }

        // This might help
        public Person()
        {
            Addresses = new List<Address>();
            this.MiddleInital = string.Empty;
        }
    }
}
