using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo
{
    public class Address
    {
        public string AddressId { get; set; }
        public string  Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string zip { get; set; }
        public string Phone { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set;  }
    }
}
