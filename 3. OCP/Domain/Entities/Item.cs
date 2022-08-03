using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._OCP.Domain.Entities
{
    internal class Item
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public decimal NetPrice => OriginalPrice - OriginalPrice * Discount;
    }
}
