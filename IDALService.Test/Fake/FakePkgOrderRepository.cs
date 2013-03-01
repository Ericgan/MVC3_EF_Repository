using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDALServices;
using Model;

namespace IDALServices.Test.Fake
{
    public class FakePkgOrderRepository : IPkgOrderRepository
    {
        private IEnumerable<PkgOrder> pkgOrders = null;
        public FakePkgOrderRepository()
        {
            pkgOrders = new List<PkgOrder>()
            {
                new PkgOrder(){ OrderId = 1},
                new PkgOrder(){ OrderId = 2},
                new PkgOrder(){ OrderId = 3},
                new PkgOrder(){ OrderId = 4},
                new PkgOrder(){ OrderId = 5},
                new PkgOrder(){ OrderId = 6}
            };
        }

        public IEnumerable<PkgOrder> GetPkgOrders()
        {
            return this.pkgOrders;
        }

        public PkgOrder GetPkgOrder(int pkgOrderId)
        {
            return this.pkgOrders.FirstOrDefault(o => o.OrderId == pkgOrderId);
        }

        public IQueryable<PkgOrder> All()
        {
            return pkgOrders.AsQueryable();
        }

        public IQueryable<Model.PkgOrder> Filter(System.Linq.Expressions.Expression<Func<Model.PkgOrder, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.PkgOrder> Filter(System.Linq.Expressions.Expression<Func<Model.PkgOrder, bool>> filter, out int total, int index = 0, int size = 50)
        {
            throw new NotImplementedException();
        }

        public bool Contains(System.Linq.Expressions.Expression<Func<Model.PkgOrder, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Model.PkgOrder Find(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public Model.PkgOrder Find(System.Linq.Expressions.Expression<Func<Model.PkgOrder, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Model.PkgOrder Create(Model.PkgOrder t)
        {
            throw new NotImplementedException();
        }

        public int Delete(Model.PkgOrder t)
        {
            throw new NotImplementedException();
        }

        public int Delete(System.Linq.Expressions.Expression<Func<Model.PkgOrder, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int Update(Model.PkgOrder t)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}