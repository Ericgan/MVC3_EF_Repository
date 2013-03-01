using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDALServices.MatCat;
using Model.MatCat;

namespace Web.Controllers
{
    public class TestRunController : Controller
    {
        private IMatCatService madcat = null;
        public TestRunController(IMatCatService service)
        {
            this.madcat = service;
        }

        //
        // GET: /TestRun/

        public ActionResult Index()
        {
            var query = this.madcat.GetTestRuns().Where<TestRun>(r => r.MachineId == 8).OrderByDescending(t=>t.RunId).Skip(30).Take(20);
            return View(query);
        }

    }
}
