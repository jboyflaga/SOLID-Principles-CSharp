using _2._DIP.Data;
using _2._DIP.Domain;
using _2._DIP.Presentation;

namespace _2._DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructing object graph
            IOrderRepository orderRepository = new OrderRepository();
            var reportGenerator = new ReportGenerator(orderRepository);
            var reportPrinter = new ReportPresenter(reportGenerator);

            // Do work
            var orderId = Guid.NewGuid();
            reportPrinter.Print(orderId);
        }
    }
}