using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.MatCat;

namespace IDALServices.MatCat
{
    public interface IMatCatService
    {
        IQueryable<TestRun> GetTestRuns();
    }
}
