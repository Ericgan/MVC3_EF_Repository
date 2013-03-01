using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Entity;
using DB;
using IDALServices;

namespace DALServices
{
    internal class Repository<TObject> : IRepository<TObject>
        where TObject : class
    {
        private bool shareContext = false;


        protected PkgOrderDB Context = null;
        public Repository()
        {
            Context = new PkgOrderDB();
        }

        public Repository(PkgOrderDB context)
        {
            this.Context = context;
            shareContext = true;
        }

        protected DbSet<TObject> DbSet
        {
            get
            {
                return Context.Set<TObject>();
            }
        }

        public IQueryable<TObject> All()
        {
            return DbSet.AsQueryable();
        }

        public IQueryable<TObject> Filter(Expression<Func<TObject, bool>> predicate)
        {
            return DbSet.Where(predicate).AsQueryable<TObject>();
        }

        public IQueryable<TObject> Filter(Expression<Func<TObject, bool>> filter, out int total, int index = 0, int size = 50)
        {
            int skipCount = index * size;
            var resultSet = filter != null ? DbSet.Where(filter).AsQueryable() : DbSet.AsQueryable();
            resultSet = skipCount == 0 ? resultSet.Take(size) : resultSet.Skip(skipCount).Take(size);
            total = resultSet.Count();
            return resultSet.AsQueryable();
        }

        public bool Contains(Expression<Func<TObject, bool>> predicate)
        {
            return DbSet.Count(predicate) > 0;
        }

        public TObject Find(params object[] keys)
        {
            return DbSet.Find(keys);
        }

        public TObject Find(Expression<Func<TObject, bool>> predicate)
        {
            return DbSet.FirstOrDefault(predicate);
        }

        public TObject Create(TObject t)
        {
            var newEntry = DbSet.Add(t);
            if (!shareContext)
                Context.SaveChanges();
            return newEntry;
        }

        public int Delete(TObject t)
        {
            DbSet.Remove(t);
            if (!shareContext)
                return Context.SaveChanges();
            return 0;
        }

        public virtual int Delete(Expression<Func<TObject, bool>> predicate)
        {
            var objects = Filter(predicate);
            foreach(var obj in objects){
                DbSet.Remove(obj);
            }

            if (!shareContext)
                return Context.SaveChanges();

            return 0;
        }

        public int Update(TObject t)
        {
            var entry = Context.Entry(t);
            DbSet.Attach(t);
            entry.State = System.Data.EntityState.Modified;
            if (!shareContext)
                return Context.SaveChanges();
            return 0;
        }

        public virtual int Count
        {
            get { return DbSet.Count(); }
        }

        public void Dispose()
        {
            if (shareContext && (Context != null))
                Context.Dispose();
        }
    }
}
