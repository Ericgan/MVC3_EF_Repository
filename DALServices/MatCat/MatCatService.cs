using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDALServices.MatCat;
using Model.MatCat;

namespace DALServices.MatCat
{
    public class MatCatService : IMatCatService
    {
        private IMatCatContext context = null;
        public MatCatService(IMatCatContext context)
        {
            this.context = context;
        }

        public IQueryable<TestRun> GetTestRuns()
        {
            return context.TestRuns.GetTestRuns();
        }
    }
}
