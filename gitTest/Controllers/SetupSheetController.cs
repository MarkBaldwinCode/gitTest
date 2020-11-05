using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gitTest.Controllers
{
    public class SetupSheetController : Controller
    {
        // GET: SetupSheet
        public ActionResult Index()
        {
            ViewBag.Message = "Your setup sheet application description page.";
            return View();
        }
    }
}