using DB;
using IDALServices;

namespace DALServices
{
    public class PkgOrderDBContext : IPkgOrderDBDALContext
    {
        private PkgOrderDB dbContext = null;
        private IPkgOrderRepository pkgOrderRepository = null;

        public PkgOrderDBContext()
        {
            this.dbContext = new PkgOrderDB();
        }

        public IPkgOrderRepository PkgOrders
        {
            get
            {
                if (pkgOrderRepository == null)
                {
                    pkgOrderRepository = new PkgOrderRepository(this.dbContext);
                }

                return pkgOrderRepository;
            }
        }

        public int SaveChanges()
        {
            return this.dbContext.SaveChanges();
        }

        public void Dispose()
        {
            if (PkgOrders != null)
                PkgOrders.Dispose();

            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
