﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDALServices;

namespace IDALServices.Test.Fake
{
    public class FakeDALContext : IDALContext
    {
        private IPkgOrderRepository pkgOrderRepository = null;

        public IPkgOrderRepository PkgOrders
        {
            get
            {
                if (pkgOrderRepository == null)
                    pkgOrderRepository = new FakePkgOrderRepository();
                return pkgOrderRepository;
            }
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}