using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._SRP_violation.Data
{
    internal class OrderRepository
    {
        public OrderDbModel GetOrder(Guid orderId)
        {
            return new OrderDbModel
            {
                Id = orderId,
                Items = new List<ItemDbModel>
                {
                    new ItemDbModel
                    {
                        Id = Guid.NewGuid(),
                        Name = "Laptop",
                        Price = 10,
                        Discount = 0.1m,
                        Quantity = 2
                    },
                    new ItemDbModel
                    {
                        Id = Guid.NewGuid(),
                        Name = "PC",
                        Price = 20,
                        Discount = 0.2m,
                        Quantity = 10
                    },
                    new ItemDbModel
                    {
                        Id = Guid.NewGuid(),
                        Name = "Phone",
                        Price = 5,
                        Discount = 0.3m,
                        Quantity = 101
                    },
                    new ItemDbModel
                    {
                        Id = Guid.NewGuid(),
                        Name = "Tablet",
                        Price = 7,
                        Discount = 0.2m,
                        Quantity = 200
                    }
                }
            };
        }
    }
}
