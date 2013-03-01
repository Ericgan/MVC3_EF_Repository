using System.Collections.Generic;
using Model;
using IDALServices;

namespace DALServices
{
    public class PkgOrderService : IPkgOrderService
    {
        private IPkgOrderDBDALContext context;

        public PkgOrderService(IPkgOrderDBDALContext context)
        {
            this.context = context;
        }

        public IEnumerable<PkgOrder> GetPkgOrders()
        {
            return context.PkgOrders.GetPkgOrders();
        }

        public PkgOrder GetPkgOrder(int pkgOrderId)
        {
            return context.PkgOrders.GetPkgOrder(pkgOrderId);
        }
    }
}
