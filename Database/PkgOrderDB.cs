using System.Data.Entity;
using Model;

namespace DB
{
    public class PkgOrderDB : DbContext
    {
        public PkgOrderDB() : base("PkgOrderDB"){ }

        public DbSet<PkgOrder> PkgOrders { get; set; }
    }
}
