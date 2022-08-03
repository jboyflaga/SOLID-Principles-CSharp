using _4._0_LSP_violation.Domain;
using _4._LSP_violation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._LSP_violation.Domain
{
    internal interface IOrderRepository : IBaseGenericRepository<Order>
    {
    }
}
