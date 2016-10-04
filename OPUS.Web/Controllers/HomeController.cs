﻿using Newtonsoft.Json;
using OPUS.Common.Utils;
using OPUS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OPUS.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        public JsonResult GetPermittedMenus(string UserName)
        {
            List<Menu> menulist = new Utility().GetMenusByUserName(UserName);

            return Json(JsonConvert.SerializeObject(menulist), JsonRequestBehavior.AllowGet);
        }
    }
}