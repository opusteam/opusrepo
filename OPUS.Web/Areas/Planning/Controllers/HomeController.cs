using OPUS.Common.Utils;
using OPUS.Domain;
using OPUS.Domain.Enums;
using OPUS.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OPUS.Web.Areas.Planning.Controllers
{
    public class HomeController : Controller
    {


        private readonly IPlanningService _planningService;
        public HomeController(IPlanningService planningService)
        {
            this._planningService = planningService;
        }


        // GET: Planning/Home
        public ActionResult Index()
        {
          
            List<VWMSLAExpiredInfo> _slalist = new Utility().GetDashBoardSLAListByDepartment(DeparmentEnum.Planning.ToString());
            return View(_slalist);
        }
    }
}