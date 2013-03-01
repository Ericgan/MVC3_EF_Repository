using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDALServices;
using IDALServices.MatCat;
using Database;
using DALServices.MatCat;

namespace DALServices
{
    public class MatCatContext : IMatCatContext
    {
        private MatCatDB dbContext = null;
        private ITestRunRepository testrunRepository = null;
        public MatCatContext()
        {
            dbContext = new MatCatDB();
        }

        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ITestRunRepository TestRuns
        {
            get
            {
                if (testrunRepository == null)
                    testrunRepository = new TestRunRepository(dbContext);
                return testrunRepository;
            }
        }
    }
}
