namespace EFCoreDemo
{
    public class InvoiceItem
    {
        public InvoiceItem()
        {
            Quantity = 0;
            UnitCost = 0;
        }

        public string InvoiceItemId { get; set; }
        public int Quantity { get; set; }
        public string PartNumber { get; set; }
        public decimal UnitCost { get; set; }
        public decimal Cost => UnitCost * Quantity;
    }
}
