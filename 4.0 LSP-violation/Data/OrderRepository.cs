using _4._LSP_violation.Domain;
using _4._LSP_violation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._LSP_violation.Data
{
    internal class OrderRepository : IOrderRepository
    {
        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Order GetById(Guid orderId)
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
