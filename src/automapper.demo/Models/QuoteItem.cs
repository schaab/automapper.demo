namespace automapper.demo.Models
{
    public class QuoteItem
    {
        public string Description { get; set; }
        public string AdditionalDescription { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string VendorName { get; set; }
    }
}