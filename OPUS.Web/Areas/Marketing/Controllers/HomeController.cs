using OPUS.Common.Utils;
using OPUS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OPUS.Web.Areas.Marketing.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Marketing/Home
        public ActionResult Index()
        {
            return View();
        }

       
    }
}