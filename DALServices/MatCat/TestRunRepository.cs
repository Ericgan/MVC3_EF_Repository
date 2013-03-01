using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.MatCat;
using IDALServices.MatCat;
using Database;

namespace DALServices.MatCat
{
    public class TestRunRepository : Repository<TestRun>, ITestRunRepository
    {
        public TestRunRepository(MatCatDB context)
            : base(context)
        {
        }

        public IQueryable<TestRun> GetTestRuns()
        {
            return DbSet.AsQueryable();
        }
    }
}
