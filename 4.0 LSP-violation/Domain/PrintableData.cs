using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._LSP_violation.Domain
{
    internal class PrintableData
    {
        public PrintableData(Guid orderNumber)
        {
            OrderNumber = orderNumber;
        }
        public Guid OrderNumber { get; }
        public IEnumerable<PrintableItem>? Items { get; set; } = new List<PrintableItem>();
        public decimal GetOverallNetPrice()
        {
            return Items?.Sum(x => x.TotalNetPrice) ?? 0;
        }
    }

    internal class PrintableItem
    {
        public string? Name { get; set; }
        public decimal DiscountedPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalNetPrice { get; set; }
    }
}
