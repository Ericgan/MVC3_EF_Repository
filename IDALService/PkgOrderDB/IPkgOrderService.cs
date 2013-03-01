using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace IDALServices
{
    public interface IPkgOrderService
    {
        IEnumerable<PkgOrder> GetPkgOrders();

        PkgOrder GetPkgOrder(int id);
    }
}
