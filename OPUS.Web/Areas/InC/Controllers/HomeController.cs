using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OPUS.Web.Areas.InC.Controllers
{
    public class HomeController : Controller
    {
        // GET: InC/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}