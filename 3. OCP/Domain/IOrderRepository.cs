using _3._OCP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._OCP.Domain
{
    internal interface IOrderRepository
    {
        Order GetOrder(Guid orderId);
    }
}
