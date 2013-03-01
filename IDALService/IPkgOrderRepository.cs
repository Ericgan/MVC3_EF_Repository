using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace IDALServices
{
    public interface IPkgOrderRepository : IRepository<PkgOrder>
    {
        IEnumerable<PkgOrder> GetPkgOrders();

        PkgOrder GetPkgOrder(int pkgOrderId);
    }
}
