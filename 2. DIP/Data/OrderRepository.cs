using _2._DIP.Domain;
using _2._DIP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._DIP.Data
{
    internal class OrderRepository : IOrderRepository
    {
        public Order GetOrder(Guid orderId)
        {
            // TODO: SQL query here

            return new Order
            {
                Id = orderId,
                Items = new List<Item>
                {
                    new Item
                    {
                        Id = Guid.NewGuid(),
                        Name = "Laptop",
                        OriginalPrice = 10,
                        Discount = 0.1m,
                        Quantity = 2
                    },
                    new Item
                    {
                        Id = Guid.NewGuid(),
                        Name = "PC",
                        OriginalPrice = 20,
                        Discount = 0.2m,
                        Quantity = 10
                    },
                    new Item
                    {
                        Id = Guid.NewGuid(),
                        Name = "Phone",
                        OriginalPrice = 5,
                        Discount = 0.3m,
                        Quantity = 101
                    },
                    new Item
                    {
                        Id = Guid.NewGuid(),
                        Name = "Tablet",
                        OriginalPrice = 7,
                        Discount = 0.2m,
                        Quantity = 200
                    }
                }
            };
        }
    }
}
