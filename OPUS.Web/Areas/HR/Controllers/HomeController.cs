﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OPUS.Web.Areas.HR.Controllers
{
    public class HomeController : Controller
    {
        // GET: HR/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}