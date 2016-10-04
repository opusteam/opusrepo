using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OPUS.Web.Areas.OverHead.Controllers
{
    public class HomeController : Controller
    {
        // GET: OverHead/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}