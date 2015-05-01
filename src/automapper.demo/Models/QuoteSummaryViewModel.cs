using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace automapper.demo.Models
{
    public class QuoteSummaryViewModel
    {
        public string AssociateName { get; set; }
        public decimal Total { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public IEnumerable<QuoteItem> QuoteItems { get; set; }
    }
}