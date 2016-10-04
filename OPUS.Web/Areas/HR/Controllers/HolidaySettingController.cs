using OPUS.Common.Utils;
using OPUS.Domain;
using OPUS.Domain.Enums;
using OPUS.Domain.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OPUS.Web.Areas.HR.Controllers
{


    public class HolidaySettingController : Controller
    {
        private readonly IHolidayService _holidayService;


        public HolidaySettingController(IHolidayService holidayService)
        {
            this._holidayService = holidayService;
        }
        // GET: HR/Settings
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SetWeeklyHoliday()
        {
             return View();
        }

        [HttpPost]
        public ActionResult SetWeeklyHoliday(VMHolidaySetting _weeklyholidays)
        {
            List<Holiday> fullholidaylist  = new Utility().GetListOfWeeklyHolidays(_weeklyholidays.WeeklyHoliday.ToString(), _weeklyholidays.year,(int)HolidayTypesEnum.Weekly_Full_Holiday,"Weekly holiday full");
            //List<Holiday> halfholidaylist = new Utility().GetListOfWeeklyHolidays(_weeklyholidays.HalfWeeklyHoliDay.ToString(), _weeklyholidays.year, (int)HolidayTypesEnum.Weekly_Half_Holiday, "Weekly holiday half");
            _holidayService.AddHolidays(fullholidaylist);
            //_holidayService.AddHolidays(halfholidaylist);
            string msg = "Weekly holiday declared successfully.";
            ViewBag.Msg = msg;
             return View();
        }

        [HttpGet]
        public ActionResult SetGovtAndOtherSpecialHolidays()
        {

            return View();
        }

        [HttpPost]
        public ActionResult SetGovtAndOtherSpecialHolidays(VWMGovtAndOtherHoliday _govtandotherholidays)
        {
            List<Holiday> govtandotherholidays = new Utility().GovtAndOtherHolidays(_govtandotherholidays);

            _holidayService.AddHolidays(govtandotherholidays);
            string msg = "Holiday declared successfully.";
            ViewBag.Msg = msg;

            return View();
        }

        [HttpGet]
        public ActionResult CalculateSLA()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CalculateSLA(TmpVMSLA _tmpSla)
        {
            VMAssignedSLA _slaobj = new Utility().getSLAByEventIdAndTrype(_tmpSla.eventId, _tmpSla.eventType.ToString());
            SLARuleSet _ruleObj = new Utility().getSLARuleById(_slaobj.SLARuleId);

            VWMSLAExpiredInfo _slaExpiredInfo = new Utility().SLAEndDateAndTime(_slaobj, DateTime.Now);

            return View("SLAInfo",_slaExpiredInfo);
        }
    }
}