using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo
{
    public class Invoice
    {
        public string InvoiceId { get; set; }
        public Person Customer { get; set; }
        public Address BillTo { get; set; }
        public Address ShipTo { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }
    }
}
