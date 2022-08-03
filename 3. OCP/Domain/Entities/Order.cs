using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._OCP.Domain.Entities
{
    internal class Order
    {
        public Guid Id { get; set; }
        public IEnumerable<Item>? Items { get; set; }
    }
}
