using _1._SRP_violation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._SRP_violation.Presentation
{
    internal class ReportPresenter
    {
        public void Present(Guid orderId)
        {
            Console.WriteLine($"SRP violation example");
            Console.WriteLine();

            // Get data from db
            var orderRepository = new OrderRepository();
            var order = orderRepository.GetOrder(orderId);

            Console.WriteLine($"Order: {order.Id}");
            Console.WriteLine($"Items:");
            Console.WriteLine($"Name\t\tPrice\tQty\tTotal");
            decimal overallNetPrice = 0;
            if (order.Items != null)
            {
                foreach (var item in order.Items)
                {
                    var itemNetPrice = item.Price - (item.Price * item.Discount);
                    var totalNetPrice = itemNetPrice * item.Quantity;
                    overallNetPrice += totalNetPrice;

                    if (item.Quantity > 100)
                    {
                        Console.Write($"{item.Name}\t\t{itemNetPrice}\t");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{item.Quantity}");
                        Console.ResetColor();
                        Console.Write($"\t{totalNetPrice}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"{item.Name}\t\t{itemNetPrice}\t{item.Quantity}\t{totalNetPrice}");
                    }
                }
            }

            Console.WriteLine($"    \t\t     \t   \t-----");
            Console.WriteLine($"    \t\t     \t   \t{overallNetPrice}");
        }
    }
}
