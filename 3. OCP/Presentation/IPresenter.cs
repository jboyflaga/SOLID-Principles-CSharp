using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._OCP.Presentation
{
    internal interface IPresenter
    {
        void Print(Guid orderId);
    }
}
