using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IDALServices;
using IDALServices.Test.Fake;
using DALServices;
using Model;

namespace IDALServices.Test
{
    [TestClass]
    public class PkgOrderServiceTest
    {
        private IPkgOrderService service = null;

        [TestInitialize]
        public void TestInitialize()
        {
            IPkgOrderDBDALContext dal = new FakeDALContext();
            service = new PkgOrderService(dal);
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        public void GetPkgOrdersTest()
        {
            var query = service.GetPkgOrders();
            Assert.AreEqual(query.Count(), 6, "PkgOrder数量不对");
        }

        [TestMethod]
        public void GetPkgOrderTest()
        {
            int orderId = 4;
            PkgOrder order = service.GetPkgOrder(orderId);
            Assert.IsNotNull(order);
            Assert.AreEqual<int>(orderId, order.OrderId);
        }
    }
}