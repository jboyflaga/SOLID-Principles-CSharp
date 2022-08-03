using _3._OCP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._OCP.Presentation
{
    internal class ReportPresenterFactory
    {
        private readonly ReportGenerator reportGenerator;

        public ReportPresenterFactory(ReportGenerator reportGenerator)
        {
            this.reportGenerator = reportGenerator;
        }

        public IPresenter? CreatePresenter(PresenterType type)
        {
            switch (type)
            {
                case PresenterType.Screen:
                    return new ReportPresenter(reportGenerator);
                case PresenterType.Printer:
                    return new ReportPrinter(reportGenerator);
            }

            return null;
        }
    }
}
