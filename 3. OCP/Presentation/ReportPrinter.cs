using _3._OCP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._OCP.Presentation
{
    internal class ReportPrinter : IPresenter
    {
        private ReportGenerator reportGenerator;

        public ReportPrinter(ReportGenerator reportGenerator)
        {
            this.reportGenerator = reportGenerator;
        }

        public void Print(Guid orderId)
        {
            // print to printer
            Console.WriteLine("Printing to printer...");
        }
    }
}
