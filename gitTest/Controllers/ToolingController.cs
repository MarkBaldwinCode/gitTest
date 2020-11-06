using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gitTest.Controllers
{
    public class ToolingController : Controller
    {
        // GET: Tooling
        public ActionResult Index()
        {
            ViewBag.Message = "Your Tooling description page.";
            return View();
        }

        public ActionResult ReOrderList()
        {
            ViewBag.Message = "Tooling Re-Order List";
            return View();
        }
    }
}