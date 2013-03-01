using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDALServices
{
    public interface IDALContext : IUnitOfWork
    {
        IPkgOrderRepository PkgOrders { get; }
    }
}
