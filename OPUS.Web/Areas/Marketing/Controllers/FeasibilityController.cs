using OPUS.Common.Utils;
using OPUS.Domain;
using OPUS.Domain.Enums;
using System.Web;
using OPUS.Domain.Services;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web.Mvc;
using Newtonsoft.Json;

namespace OPUS.Web.Areas.Marketing.Controllers
{

    [Authorize]
    public class FeasibilityController : Controller
    {
        private readonly IFeasibilityService _feasibilityService;
        private const int defaultPageSize = 2;
        private string tempview = null;

        public FeasibilityController(IFeasibilityService feasibilityservice)
        {
            this._feasibilityService = feasibilityservice;
        }

        // GET: Marketing/Feasibility
        public ActionResult Index()
        {
            return RedirectToAction("FeasibilityRequestList");
            //return View();
        }

        public ActionResult FeasibilityRequestList(int? page)
        {
            int currentPageIndex = page.HasValue ? page.Value : 1;
            List<Feasibility> _feasibilityList = _feasibilityService.GetAll();// PagingList(2,2);
            _feasibilityList = _feasibilityList.Where(x => x.Status == FeasibilityStatusEnum.NewBorn.ToString() || x.Status == null ).ToList();
            return View(_feasibilityList.ToPagedList(currentPageIndex, defaultPageSize));
            
        }

        // GET: Marketing/Feasibility/Edit
        public ActionResult Edit(int Id)
        {
            Feasibility fr = _feasibilityService.FindFeasibilityById(Id);

            List<Client> client = _feasibilityService.getAllClient();
            client = client.Where(x => x.KamId == User.Identity.Name).ToList();
            List<SelectListItem> _clist = new List<SelectListItem>();

            foreach (var cl in client)
            {
                _clist.Add(new SelectListItem { Text = cl.Name, Value = cl.Id.ToString() });
            }

            ViewBag.clientList = _clist;

           
            FeasibilityViewModel fobj = new FeasibilityViewModel();


            fobj.FId = fr.Id;
            fobj.FeasiblityType = fr.FeasiblityType.ToEnumSafe<FeasibilityTypeEnum>();
            fobj.ClientId = fr.ClientId;
            fobj.Requestfor = fr.Requestfor.ToEnumSafe<RequestForEnum>();

            fobj.ConnectivityType = fr.ConnectivityType.ToEnumSafe<ConnectivityTypeEnum>(); //(ConnectivityTypeEnum)Enum.Parse(typeof(ConnectivityTypeEnum), fr.ConnectivityType),

            //ConnectionType is only for Passive Feasibility Request
            fobj.ConnectionType = fr.ConnectionType.ToEnumSafe<ConnectionTypeEnum>();
            fobj.AddressOfClientLocationA = fr.AddressOfClientLocationA;
            fobj.LongitudeOfClientLocationA = fr.LongitudeOfClientLocationA;
            fobj.LatitudeOfClientLocationA = fr.LatitudeOfClientLocationA;

            fobj.AddressOfClientLocationB = fr.AddressOfClientLocationB;
            fobj.LongitudeOfClientLocationB = fr.LongitudeOfClientLocationB;
            fobj.LatitudeOfClientLocationB = fr.LatitudeOfClientLocationB;

            fobj.IsExistingInterfaceForLocationA = fr.IsExistingInterfaceForLocationA.ToEnumSafe<YesNoEnum>();
            fobj.IsExistingInterfaceForLocationB = fr.IsExistingInterfaceForLocationB.ToEnumSafe<YesNoEnum>();

            fobj.ServiceType = fr.ServiceType.ToEnumSafe<ServiceTypeEnum>();

            fobj.RequiredCapacityQuantity = fr.RequiredCapacityQuantity;
            fobj.RequiredCapacityUnit = fr.RequiredCapacityUnit.ToEnumSafe<CapacityRequirementUnitEnum>();

            fobj.InterfaceType = fr.InterfaceType.ToEnumSafe<InterfaceTypeEnum>();
            fobj.InterfaceTypeUnit = fr.InterfaceTypeUnit.ToEnumSafe<InterfaceTypeUnitEnum>();

            fobj.InterfaceCategory = fr.InterfaceCategory.ToEnumSafe<InterfaceCategoryEnum>();
            //if InterfaceCategory == Ethernet_Layer_2
            fobj.SubcategoryOfInterfaceCategory = fr.SubcategoryOfInterfaceCategory.ToEnumSafe<InterfaceEthernetLayer2SubCategoryEnum>();
            fobj.ClientVLANID = fr.ClientVLANID;

            fobj.LastMileBy = fr.LastMileBy.ToEnumSafe<LastMileByEnum>();
            //If LastMileBy == SCL
            fobj.LastMileServiceTypeOfLocationA = fr.LastMileServiceTypeOfLocationA.ToEnumSafe<LastMileServiceTypeEnum>();
            fobj.LastMileImplementationTypeOfLocationA = fr.LastMileImplementationTypeOfLocationA.ToEnumSafe<LastMileImplementationTypeEnum>();

            fobj.LastMileServiceTypeOfLocationB = fr.LastMileServiceTypeOfLocationB.ToEnumSafe<LastMileServiceTypeEnum>();
            fobj.LastMileImplementationTypeOfLocationB = fr.LastMileImplementationTypeOfLocationB.ToEnumSafe<LastMileImplementationTypeEnum>();

            fobj.KAMRemarks = fr.KAMRemarks;

            return View(fobj);
        }

      
        public ActionResult FeasibilityRequest()
        {
            List<Client> client = _feasibilityService.getAllClient();
            client = client.Where(x => x.KamId == User.Identity.Name).ToList();
            List<SelectListItem> _clist = new List<SelectListItem>();

            foreach (var cl in client)
            {
                _clist.Add(new SelectListItem { Text = cl.Name, Value = cl.Id.ToString() });
            }

            ViewBag.clientList = _clist;

            return View();

        }


        public JsonResult SaveFeasibilityRequest(FeasibilityViewModel feasibilityobj)
        {
            if (ModelState.IsValid)
            {
               
                Feasibility _newfr = new Utility().GetFeasibilityObject(feasibilityobj,User.Identity.Name);
                _feasibilityService.Add(_newfr);

                var _Id = _newfr.Id;
                AssignedSLA _asla = new Utility().GetSLAObject(Properties.Settings.Default.RuleIdFeasibilityFeedBackWithoutSurvey, _Id, DeparmentEnum.Planning.ToString(), User.Identity.Name);

                _feasibilityService.SetSLA(_asla);

                return Json("Feasibility request created successfully", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Please provide all required & valid information", JsonRequestBehavior.AllowGet);
            }
        }


        public JsonResult UpdateFeasibilityRequest(FeasibilityViewModel feasibilityobj,int fId)
        {
            if (ModelState.IsValid)
            {
                Feasibility fr = _feasibilityService.FindFeasibilityById(fId);

                Feasibility _revisedfr = new Utility().UpdateFeasibility(fr, feasibilityobj, fId,User.Identity.Name);
                _feasibilityService.Update(_revisedfr);

                return Json("Feasibility request update successfull", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Please provide all required & valid information", JsonRequestBehavior.AllowGet);
            }
        }

        // Feedback Plan List
        // GET: Marketing/FeedbackList
        public ActionResult FeedbackList(int? page)
        {
            int currentPageIndex = page.HasValue ? page.Value : 1;
            List<Feasibility> _feasibilityList = _feasibilityService.GetAll();// PagingList(2,2);
            _feasibilityList = _feasibilityList.Where(x => x.Status == FeasibilityStatusEnum.FeedBacked.ToString()).ToList();

            return View("FeedbackList", _feasibilityList.ToPagedList(currentPageIndex, defaultPageSize));
        }

        // GET: Marketing/Feasibility/FeasibilityFeedback/
        public ActionResult FeasibilityFeedback(int Id)
        {
            Feasibility fr = _feasibilityService.FindFeasibilityById(Id);

            List<Client> client = _feasibilityService.getAllClient();
            client = client.Where(x => x.KamId == User.Identity.Name).ToList();
            List<SelectListItem> _clist = new List<SelectListItem>();

            foreach (var cl in client)
            {
                _clist.Add(new SelectListItem { Text = cl.Name, Value = cl.Id.ToString() });
            }

            ViewBag.clientList = _clist;


            FeasibilityViewModel fobj = new FeasibilityViewModel();


            fobj.FId = fr.Id;
            fobj.FeasiblityType = fr.FeasiblityType.ToEnumSafe<FeasibilityTypeEnum>();
            fobj.ClientName = _feasibilityService.FindClientById(fr.ClientId).Name;
            fobj.Requestfor = fr.Requestfor.ToEnumSafe<RequestForEnum>();

            fobj.ConnectivityType = fr.ConnectivityType.ToEnumSafe<ConnectivityTypeEnum>(); //(ConnectivityTypeEnum)Enum.Parse(typeof(ConnectivityTypeEnum), fr.ConnectivityType),

            //ConnectionType is only for Passive Feasibility Request
            fobj.ConnectionType = fr.ConnectionType.ToEnumSafe<ConnectionTypeEnum>();

            fobj.AddressOfClientLocationA = fr.AddressOfClientLocationA;
            fobj.LongitudeOfClientLocationA = fr.LongitudeOfClientLocationA;
            fobj.LatitudeOfClientLocationA = fr.LatitudeOfClientLocationA;

            fobj.AddressOfSCLPOPLocationA = fr.AddressOfSCLPOPLocationA;
            fobj.LongitudeOfSCLPOPLocationA = fr.LongitudeOfSCLPOPLocationA;
            fobj.LatitudeOfSCLPOPLocationA = fr.LatitudeOfSCLPOPLocationA;

            fobj.AddressOfClientLocationB = fr.AddressOfClientLocationB;
            fobj.LongitudeOfClientLocationB = fr.LongitudeOfClientLocationB;
            fobj.LatitudeOfClientLocationB = fr.LatitudeOfClientLocationB;

            fobj.AddressOfSCLPOPLocationB = fr.AddressOfSCLPOPLocationB;
            fobj.LongitudeOfSCLPOPLocationB = fr.LongitudeOfSCLPOPLocationB;
            fobj.LatitudeOfSCLPOPLocationB = fr.LatitudeOfSCLPOPLocationB;

            fobj.IsExistingInterfaceForLocationA = fr.IsExistingInterfaceForLocationA.ToEnumSafe<YesNoEnum>();
            fobj.IsExistingInterfaceForLocationB = fr.IsExistingInterfaceForLocationB.ToEnumSafe<YesNoEnum>();

            fobj.ServiceType = fr.ServiceType.ToEnumSafe<ServiceTypeEnum>();

            fobj.RequiredCapacityQuantity = fr.RequiredCapacityQuantity;
            fobj.RequiredCapacityUnit = fr.RequiredCapacityUnit.ToEnumSafe<CapacityRequirementUnitEnum>();

            fobj.InterfaceType = fr.InterfaceType.ToEnumSafe<InterfaceTypeEnum>();
            fobj.InterfaceTypeUnit = fr.InterfaceTypeUnit.ToEnumSafe<InterfaceTypeUnitEnum>();

            fobj.InterfaceCategory = fr.InterfaceCategory.ToEnumSafe<InterfaceCategoryEnum>();
            //if InterfaceCategory == Ethernet_Layer_2
            fobj.SubcategoryOfInterfaceCategory = fr.SubcategoryOfInterfaceCategory.ToEnumSafe<InterfaceEthernetLayer2SubCategoryEnum>();
            fobj.LastMileBy = fr.LastMileBy.ToEnumSafe<LastMileByEnum>();
            //If LastMileBy == SCL
            fobj.LastMileServiceTypeOfLocationA = fr.LastMileServiceTypeOfLocationA.ToEnumSafe<LastMileServiceTypeEnum>();
            fobj.LastMileImplementationTypeOfLocationA = fr.LastMileImplementationTypeOfLocationA.ToEnumSafe<LastMileImplementationTypeEnum>();

            fobj.LastMileServiceTypeOfLocationB = fr.LastMileServiceTypeOfLocationB.ToEnumSafe<LastMileServiceTypeEnum>();
            fobj.LastMileImplementationTypeOfLocationB = fr.LastMileImplementationTypeOfLocationB.ToEnumSafe<LastMileImplementationTypeEnum>();

            fobj.KAMRemarks = fr.KAMRemarks;
            fobj.PlanningRemarks = fr.PlanningRemarks;

            //Possible-NotPossible dropdown populating

            fobj.IsPossibleWithSelectedConnectionType = fr.IsPossibleWithSelectedConnectionType.ToEnumSafe<PossibleNotPossibleEnum>();
            fobj.IsPossibleWithExistingInterfaceForLocationA = fr.IsPossibleWithExistingInterfaceForLocationA.ToEnumSafe<PossibleNotPossibleEnum>();
            fobj.IsPossibleWithExistingInterfaceForLocationB = fr.IsPossibleWithExistingInterfaceForLocationB.ToEnumSafe<PossibleNotPossibleEnum>();
            fobj.IsServicePossibleWithSelectedServiceType = fr.IsServicePossibleWithSelectedServiceType.ToEnumSafe<PossibleNotPossibleEnum>();
            fobj.IsRequiredCapacityDeliveryPossible = fr.IsRequiredCapacityDeliveryPossible.ToEnumSafe<PossibleNotPossibleEnum>();
            fobj.IsInterfaceTypePossible = fr.IsInterfaceTypePossible.ToEnumSafe<PossibleNotPossibleEnum>();
            fobj.IsInterfacecategoryPossible = fr.IsInterfacecategoryPossible.ToEnumSafe<PossibleNotPossibleEnum>();
            fobj.IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType = fr.IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType.ToEnumSafe<PossibleNotPossibleEnum>();
            fobj.IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType = fr.IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType.ToEnumSafe<PossibleNotPossibleEnum>();
            fobj.IsPossibleLastMileServiceTypeOfLocationBBySelectedServiceType = fr.IsPossibleLastMileServiceTypeOfLocationBBySelectedServiceType.ToEnumSafe<PossibleNotPossibleEnum>();
            fobj.IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType = fr.IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType.ToEnumSafe<PossibleNotPossibleEnum>();

            //Populate Remarks

            List<ProcessRemark> _remarksList = _feasibilityService.getAllPossibleNotPossibleRemarks();
            _remarksList = _remarksList.Where(x => x.FeasibilityId == fr.Id).ToList();

            foreach(var _processremark in _remarksList)
            {
                if(_processremark.Remarksfor== ProcessRequestForEnum.NotPossibleWithSelectedConnectionType.ToString())
                {
                    fobj.NotPossibleRemarks_WithSelectedConnectionType = _processremark.Remarks;

                }
                else if(_processremark.Remarksfor == ProcessRequestForEnum.NotPossibleWithExistingInterfaceForLocationA.ToString())
                {
                    fobj.NotPossibleRemarks_WithExistingInterfaceForLacationA = _processremark.Remarks;
                }
                else if (_processremark.Remarksfor == ProcessRequestForEnum.NotPossibleWithExistingInterfaceForLocationB.ToString())
                {
                    fobj.NotPossibleRemarks_WithExistingInterfaceForLacationB = _processremark.Remarks;
                }
                else if (_processremark.Remarksfor == ProcessRequestForEnum.ServiceNotPossibleWithSelectedServiceType.ToString())
                {
                    fobj.NotPossibleRemarks_WithSelectedServiceType = _processremark.Remarks;
                }
                else if (_processremark.Remarksfor == ProcessRequestForEnum.RequiredCapacityDeliveryNotPossible.ToString())
                {
                    fobj.NotPossibleRemarks_IsRequiredCapacityDeliveryPossible = _processremark.Remarks;
                }
                else if (_processremark.Remarksfor == ProcessRequestForEnum.InterfaceTypeNotPossible.ToString())
                {
                    fobj.NotPossibleRemarks_IsInterfaceTypePossible = _processremark.Remarks;
                }
                else if (_processremark.Remarksfor == ProcessRequestForEnum.InterfacecategoryNotPossible.ToString())
                {
                    fobj.NotPossibleRemarks_IsInterfacecategoryPossible = _processremark.Remarks;
                }
                else if (_processremark.Remarksfor == ProcessRequestForEnum.NotPossibleLastMileServiceTypeOfLocationABySelectedServiceType.ToString())
                {
                    fobj.NotPossibleRemarks_LastMileServiceTypeOfLocationABySelectedServiceType = _processremark.Remarks;
                }
                else if (_processremark.Remarksfor == ProcessRequestForEnum.NotPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType.ToString())
                {
                    fobj.NotPossibleRemarks_LastMileImplementationTypeOfLocationAForSelectedImplementationType = _processremark.Remarks;
                }
                else if (_processremark.Remarksfor == ProcessRequestForEnum.NotPossibleLastMileServiceTypeOfLocationABySelectedServiceType.ToString())
                {
                    fobj.NotPossibleRemarks_LastMileServiceTypeOfLocationBBySelectedServiceType = _processremark.Remarks;
                }
                else if (_processremark.Remarksfor == ProcessRequestForEnum.NotPossibleLastMileServiceTypeOfLocationBBySelectedServiceType.ToString())
                {
                    fobj.NotPossibleRemarks_LastMileImplementationTypeOfLocationBForSelectedImplementationType = _processremark.Remarks;
                }

            }
            //END Remarks section

            //Work Order Properties section
            //fobj.FromCoreColor = ToEnumSafe<ColorCodeEnum>();
            //End WO properties section

            if (fr.FeasiblityType == "Active")
            {
                ViewBag.Title = "Issue Work Order for Active Feasibility";
                tempview = "AFWorkWorderForm";
            }
            else
            {
                ViewBag.Title = "Issue Work Order for Passive Feasibility";
                tempview = "PFWorkWorderForm";
            }

            //FeasibilityViewModel fobj = new FeasibilityViewModel();

            return View(tempview, fobj);
        }

        private string getValue(string val)
        {

            int _val;
            if (int.TryParse(val, out _val))
            {
                _val = 0;
            }
            else { _val = 1; }

            if (_val == 0)
            {
                return null;
            }
            else
            {

                return val;
            }
        }

        public JsonResult LoadCancelReason()
        {
            List<CancelReason> _cancelreasonlist = _feasibilityService.getAllCancelReasons();

            if (_cancelreasonlist.Count > 0) {

                return Json(JsonConvert.SerializeObject(_cancelreasonlist), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("No reason in database", JsonRequestBehavior.AllowGet);
            }
        }

        [AllowAnonymous]
        public JsonResult SaveActiveWorkOrder(WorkOrderCoreViewModel wocore, InputsForWorkorder woobject)
        {
            if (ModelState.IsValid)
            {
                WorkOrder wo = new WorkOrder();
                wo.FeasibilityId = wocore.FeasibilityId;
                wo.Remarks = wocore.Remarks;
                wo.Date = DateTime.Now;

                _feasibilityService.AddWorkOrder(wo);
                var woid = wo.Id;

                List<WorkOrderDetail> _wodetail = new List<WorkOrderDetail>();
                foreach (var worder in woobject.WorkOrderProperties.ToList())
                {
                    WorkOrderDetail _workorder = new WorkOrderDetail();
                    _workorder.WorkOrderId = woid;
                    _workorder.FromCableId = worder.FromCableId;
                    _workorder.ToCableId = worder.ToCableId;
                    _workorder.FromCoreColor = worder.FromCoreColor;
                    _workorder.ToCoreColor = worder.ToCoreColor;

                    _wodetail.Add(_workorder);


                }

                if (_wodetail != null)
                {
                    _feasibilityService.AddWorkOrderDetail(_wodetail);
                }

                return Json("Successfully saved", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Something went wrong!", JsonRequestBehavior.AllowGet);
            }

        }
    }
}