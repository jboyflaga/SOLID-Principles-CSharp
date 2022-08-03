using _3._OCP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._OCP.Domain
{
    internal class ReportGenerator
    {
        private readonly IOrderRepository orderRepository;

        public ReportGenerator(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public PrintableData GenerateReportData(Guid orderId)
        {
            var order = orderRepository.GetOrder(orderId);

            // Convert raw data to printable data
            var printableData = new PrintableData(order.Id);
            printableData.Items = (from item in order.Items
                                   select new PrintableItem
                                   {
                                      Name = item.Name,
                                      DiscountedPrice = item.NetPrice,
                                      Quantity = item.Quantity,
                                      TotalNetPrice = item.NetPrice * item.Quantity
                                   })
                                  .ToList();
            return printableData;
        }

    }
}
