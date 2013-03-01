using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Model.MatCat;

namespace Database
{
    public class MatCatDB : DbContext
    {
        public MatCatDB() : base("name=MadCat") { }

        public DbSet<TestRun> TestRuns { get; set; }
    }
}
