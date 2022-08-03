using _4._LSP_violation.Data;
using _4._LSP_violation.Domain;
using _4._LSP_violation.Presentation;

namespace _4._LSP_violation
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
            //var orderId = Guid.NewGuid();
            int orderId = 111;
            reportPrinter.Present(orderId);
        }
    }
}