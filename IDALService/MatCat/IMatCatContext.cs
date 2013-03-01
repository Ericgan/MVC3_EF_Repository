using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDALServices.MatCat
{
    public interface IMatCatContext : IUnitOfWork
    {
        ITestRunRepository TestRuns { get; }
    }
}
