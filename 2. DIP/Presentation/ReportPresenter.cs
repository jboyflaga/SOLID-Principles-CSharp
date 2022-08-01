using _2._DIP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._DIP.Presentation
{
    internal class ReportPresenter
    {
        private readonly ReportGenerator reportGenerator;

        public ReportPresenter(ReportGenerator reportGenerator)
        {
            this.reportGenerator = reportGenerator;
        }

        public void Print(Guid orderId)
        {
            PrintableData data = reportGenerator.GenerateReportData(orderId);

            Console.WriteLine($"DIP example");
            Console.WriteLine();

            Console.WriteLine($"Order: {data.OrderNumber}");
            Console.WriteLine($"Items:");
            Console.WriteLine($"Name\t\tPrice\tQty\tTotal");
            if (data.Items != null)
                foreach (var item in data.Items)
                {
                    if (item.Quantity > 100)
                    {
                        Console.Write($"{item.Name}\t\t{item.DiscountedPrice}\t");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{item.Quantity}");
                        Console.ResetColor();
                        Console.Write($"\t{item.TotalNetPrice}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"{item.Name}\t\t{item.DiscountedPrice}\t{item.Quantity}\t{item.TotalNetPrice}");
                    }
                }

            Console.WriteLine($"    \t\t     \t   \t-----");
            Console.WriteLine($"    \t\t     \t   \t{data.GetOverallNetPrice()}");
        }
    }
}
