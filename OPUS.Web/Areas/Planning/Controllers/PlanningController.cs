using OPUS.Common.Utils;
using OPUS.Domain;
using OPUS.Domain.Enums;
using OPUS.Domain.Services;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OPUS.Web.Areas.Planning.Controllers
{
    [Authorize]
    public class PlanningController : Controller
    {
        // GET: Planning/Planning

        private readonly IPlanningService _planningService;
        private const int defaultPageSize = 2;
        private string tempview = null;

        public PlanningController(IPlanningService planningService)
        {
            this._planningService = planningService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FeasibilityList(int? page)
        {
            int currentPageIndex = page.HasValue ? page.Value : 1;
            List<Feasibility> _feasibilityList = _planningService.GetAll();// PagingList(2,2);

           // _feasibilityList = _feasibilityList.Where(x => x.Status == FeasibilityStatusEnum.FeedBacked.ToString()).ToList();
            _feasibilityList = _feasibilityList.Where(x => x.Status == FeasibilityStatusEnum.NewBorn.ToString() || x.Status == null).ToList();
            return View(_feasibilityList.ToPagedList(currentPageIndex, defaultPageSize));

        }
        // GET: Planning/Panning/WorkOrderList 
        public ActionResult WorkOrderList(int? page)
        {
            int currentPageIndex = page.HasValue ? page.Value : 1;
            List<Feasibility> _feasibilityList = _planningService.GetAll();// PagingList(2,2);

            // _feasibilityList = _feasibilityList.Where(x => x.Status == FeasibilityStatusEnum.FeedBacked.ToString()).ToList();
            _feasibilityList = _feasibilityList.Where(x => x.Status == FeasibilityStatusEnum.WorkOrdered.ToString() || x.Status == null).ToList();
            return View(_feasibilityList.ToPagedList(currentPageIndex, defaultPageSize));

        }

        // GET: Planning/Panning/FeasibilityFeedback
        public ActionResult FeasibilityFeedback(int Id)
        {
            Feasibility fr = _planningService.FindFeasibilityById(Id);

            List<Client> client = _planningService.getAllClient();
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
            fobj.ClientName = _planningService.FindClientById(fr.ClientId ).Name;
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
            fobj.ClientVLANID = fr.ClientVLANID;

            fobj.LastMileBy = fr.LastMileBy.ToEnumSafe<LastMileByEnum>();
            //If LastMileBy == SCL
            fobj.LastMileServiceTypeOfLocationA = fr.LastMileServiceTypeOfLocationA.ToEnumSafe<LastMileServiceTypeEnum>();
            fobj.LastMileImplementationTypeOfLocationA = fr.LastMileImplementationTypeOfLocationA.ToEnumSafe<LastMileImplementationTypeEnum>();

            fobj.LastMileServiceTypeOfLocationB = fr.LastMileServiceTypeOfLocationB.ToEnumSafe<LastMileServiceTypeEnum>();
            fobj.LastMileImplementationTypeOfLocationB = fr.LastMileImplementationTypeOfLocationB.ToEnumSafe<LastMileImplementationTypeEnum>();

            //IsPossible

            fobj.IsPossibleWithExistingInterfaceForLocationA = PossibleNotPossibleEnum.Possible; //fr.IsPossibleWithExistingInterfaceForLocationA.ToEnumSafe<PossibleNotPossibleEnum>(); 
            fobj.IsPossibleWithExistingInterfaceForLocationB = PossibleNotPossibleEnum.Possible; //fr.IsPossibleWithExistingInterfaceForLocationB.ToEnumSafe<PossibleNotPossibleEnum>();

            fobj.IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType = PossibleNotPossibleEnum.Possible; //fr.IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType.ToEnumSafe<PossibleNotPossibleEnum>();
            fobj.IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType = PossibleNotPossibleEnum.Possible; //fr.IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType.ToEnumSafe<PossibleNotPossibleEnum>();

            fobj.IsPossibleLastMileServiceTypeOfLocationBBySelectedServiceType = PossibleNotPossibleEnum.Possible; //fr.IsPossibleLastMileServiceTypeOfLocationBBySelectedServiceType.ToEnumSafe<PossibleNotPossibleEnum>();
            fobj.IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType = PossibleNotPossibleEnum.Possible; //fr.IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType.ToEnumSafe<PossibleNotPossibleEnum>();

            fobj.IsInterfaceTypePossible = PossibleNotPossibleEnum.Possible;
            fobj.IsInterfacecategoryPossible = PossibleNotPossibleEnum.Possible;

            fobj.IsPossibleWithSelectedConnectionType = PossibleNotPossibleEnum.Possible; //fr.IsPossibleWithSelectedConnectionType.ToEnumSafe< PossibleNotPossibleEnum>();
            fobj.IsServicePossibleWithSelectedServiceType = PossibleNotPossibleEnum.Possible; //fr.IsServicePossibleWithSelectedServiceType.ToEnumSafe<PossibleNotPossibleEnum>();
            fobj.IsRequiredCapacityDeliveryPossible = fobj.IsRequiredCapacityDeliveryPossible;

            fobj.KAMRemarks = fr.KAMRemarks;
            fobj.PlanningRemarks = fr.PlanningRemarks;

            //Populate Remarks

            List<ProcessRemark> _remarksList = _planningService.getAllPossibleNotPossibleRemarks();
            _remarksList = _remarksList.Where(x => x.FeasibilityId == fr.Id).ToList();

            foreach (var _processremark in _remarksList)
            {
                if (_processremark.Remarksfor == ProcessRequestForEnum.NotPossibleWithSelectedConnectionType.ToString())
                {
                    fobj.NotPossibleRemarks_WithSelectedConnectionType = _processremark.Remarks;

                }
                else if (_processremark.Remarksfor == ProcessRequestForEnum.NotPossibleWithExistingInterfaceForLocationA.ToString())
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
                else if (_processremark.Remarksfor == ProcessRequestForEnum.NotPossibleLastMileServiceTypeOfLocationBBySelectedServiceType.ToString())
                {
                    fobj.NotPossibleRemarks_LastMileServiceTypeOfLocationBBySelectedServiceType = _processremark.Remarks;
                }
                else if (_processremark.Remarksfor == ProcessRequestForEnum.NotPossibleLastMileServiceTypeOfLocationBBySelectedServiceType.ToString())
                {
                    fobj.NotPossibleRemarks_LastMileImplementationTypeOfLocationBForSelectedImplementationType = _processremark.Remarks;
                }

            }
            //END Remarks section

            if (fr.FeasiblityType == "Active")
            {
                ViewBag.Title = "Active Feasibility Feedback";
                tempview = "ActiveFeasibilityFeedback";
            }
            else
            {
                ViewBag.Title = "Passive Feasibility Feedback";
                tempview = "PassiveFeasibilityFeedback";
            }

            //FeasibilityViewModel fobj = new FeasibilityViewModel();

            return View(tempview, fobj);
        }

       
        public JsonResult SaveActiveFeasibilityFeedBack(PlanningFeedBackOnActiveFeasibility feedbackObject)
        {
           
                Feasibility fr = _planningService.FindFeasibilityById(feedbackObject.FeasibilityId);

                fr.AddressOfSCLPOPLocationA = feedbackObject.AddressOfSCLPOPLocationA;
                fr.LatitudeOfSCLPOPLocationA = feedbackObject.LatitudeOfSCLPOPLocationA;
                fr.LongitudeOfSCLPOPLocationA = feedbackObject.LongitudeOfSCLPOPLocationA;

                fr.AddressOfSCLPOPLocationB = feedbackObject.AddressOfSCLPOPLocationB;
                fr.LatitudeOfSCLPOPLocationB = feedbackObject.LatitudeOfSCLPOPLocationB;
                fr.LongitudeOfSCLPOPLocationB = feedbackObject.LongitudeOfSCLPOPLocationB;

                fr.IsPossibleWithExistingInterfaceForLocationA = feedbackObject.IsPossibleWithExistenceInterfaceForLocationA;
                fr.IsPossibleWithExistingInterfaceForLocationB = feedbackObject.IsPossibleWithExistenceInterfaceForLocationB;


                fr.IsInterfaceTypePossible = feedbackObject.IsPossibleWithSelectedInterface;
                fr.IsInterfacecategoryPossible = feedbackObject.IsPossibleWithSelectedInterfaceCategory;
                fr.IsServicePossibleWithSelectedServiceType = feedbackObject.IsPossibleWithSelectedServiceType;
                fr.IsRequiredCapacityDeliveryPossible = feedbackObject.IsPossibleToDeliverRequiredCapacity;

                fr.IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType = feedbackObject.IsPossibleLastMileSelectedServiceTypeForLocationA;
                fr.IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType = feedbackObject.IsPossibleLastMileImplementationTypeForLocationA;

                fr.IsPossibleLastMileServiceTypeOfLocationBBySelectedServiceType = feedbackObject.IsPossibleLastMileSelectedServiceTypeForLocationB;
                fr.IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType = feedbackObject.IsPossibleLastMileImplementationTypeForLocationB;
                fr.Status = FeasibilityStatusEnum.FeedBacked.ToString();
                fr.PlanningRemarks = feedbackObject.PlanningRemarks;

                VMAssignedSLA _slaobj = new Utility().getSLAByEventIdAndTrype(feedbackObject.FeasibilityId, fr.SLAtype);
                SLARuleSet _ruleObj = new Utility().getSLARuleById(_slaobj.SLARuleId);

                VWMSLAExpiredInfo _slaExpiredInfo = new Utility().SLAEndDateAndTime(_slaobj, DateTime.Now);


                 new Utility().UpdateAssignedSLAStatus(_slaExpiredInfo);


            _planningService.Update(fr);

                _planningService.AddRemarks(feedbackObject.ProcessRemarks);


                return Json("Feasibility request update successfull", JsonRequestBehavior.AllowGet);
            

        }


        public JsonResult SavePassiveFeasibilityFeedBack(PlanningFeedBackOnPassiveFeasibility feedbackObject)
        {

            Feasibility fr = _planningService.FindFeasibilityById(feedbackObject.FeasibilityId);

            fr.AddressOfSCLPOPLocationA = feedbackObject.AddressOfSCLPOPLocationA;
            fr.LatitudeOfSCLPOPLocationA = feedbackObject.LatitudeOfSCLPOPLocationA;
            fr.LongitudeOfSCLPOPLocationA = feedbackObject.LongitudeOfSCLPOPLocationA;

            fr.AddressOfSCLPOPLocationB = feedbackObject.AddressOfSCLPOPLocationB;
            fr.LatitudeOfSCLPOPLocationB = feedbackObject.LatitudeOfSCLPOPLocationB;
            fr.LongitudeOfSCLPOPLocationB = feedbackObject.LongitudeOfSCLPOPLocationB;

            fr.IsPossibleWithSelectedConnectionType = feedbackObject.IsPossibleWithSelectedConnectionType;
            fr.IsServicePossibleWithSelectedServiceType = feedbackObject.IsServicePossibleWithSelectedServiceType;


            //ConnectionType is only for Passive Feasibility Request
            fr.IsRequiredCapacityDeliveryPossible = feedbackObject.IsRequiredCapacityDeliveryPossible;
            fr.IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType = feedbackObject.IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType;
            fr.IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType = feedbackObject.IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType;

            fr.IsPossibleLastMileServiceTypeOfLocationBBySelectedServiceType = feedbackObject.IsPossibleLastMileServiceTypeOfLocationBBySelectedServiceType;
            fr.IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType = feedbackObject.IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType;
            fr.Status = FeasibilityStatusEnum.FeedBacked.ToString();
            fr.PlanningRemarks = feedbackObject.PlanningRemarks;

            _planningService.Update(fr);

            _planningService.AddRemarks(feedbackObject.ProcessRemarks);


            return Json("Feasibility request update successfull", JsonRequestBehavior.AllowGet);

        }

        // GET: Planning/Panning/FinalPlan
        public ActionResult FinalPlan(int Id)
        {
            Feasibility fr = _planningService.FindFeasibilityById(Id);

            FinalPlanViewModel fobj = new FinalPlanViewModel();

            fobj.FId = fr.Id;
            fobj.FeasiblityType = fr.FeasiblityType;
            //fobj.ClientName = _planningService.FindClientById(fr.ClientId).Name;
            //fobj.Requestfor = fr.Requestfor.ToEnumSafe<RequestForEnum>();

            //fobj.ConnectivityType = fr.ConnectivityType.ToEnumSafe<ConnectivityTypeEnum>(); //(ConnectivityTypeEnum)Enum.Parse(typeof(ConnectivityTypeEnum), fr.ConnectivityType),

            ////ConnectionType is only for Passive Feasibility Request
            //fobj.ConnectionType = fr.ConnectionType.ToEnumSafe<ConnectionTypeEnum>();
            //fobj.AddressOfClientLocationA = fr.AddressOfClientLocationA;
            //fobj.LongitudeOfClientLocationA = fr.LongitudeOfClientLocationA;
            //fobj.LatitudeOfClientLocationA = fr.LatitudeOfClientLocationA;

            //fobj.AddressOfSCLPOPLocationA = fr.AddressOfSCLPOPLocationA;
            //fobj.LongitudeOfSCLPOPLocationA = fr.LongitudeOfSCLPOPLocationA;
            //fobj.LatitudeOfSCLPOPLocationA = fr.LatitudeOfSCLPOPLocationA;

            //fobj.AddressOfClientLocationB = fr.AddressOfClientLocationB;
            //fobj.LongitudeOfClientLocationB = fr.LongitudeOfClientLocationB;
            //fobj.LatitudeOfClientLocationB = fr.LatitudeOfClientLocationB;

            //fobj.AddressOfSCLPOPLocationB = fr.AddressOfSCLPOPLocationB;
            //fobj.LongitudeOfSCLPOPLocationB = fr.LongitudeOfSCLPOPLocationB;
            //fobj.LatitudeOfSCLPOPLocationB = fr.LatitudeOfSCLPOPLocationB;

            //fobj.IsExistingInterfaceForLocationA = fr.IsExistingInterfaceForLocationA.ToEnumSafe<YesNoEnum>();
            //fobj.IsExistingInterfaceForLocationB = fr.IsExistingInterfaceForLocationB.ToEnumSafe<YesNoEnum>();

            //fobj.ServiceType = fr.ServiceType.ToEnumSafe<ServiceTypeEnum>();

            //fobj.RequiredCapacityQuantity = fr.RequiredCapacityQuantity;
            //fobj.RequiredCapacityUnit = fr.RequiredCapacityUnit.ToEnumSafe<CapacityRequirementUnitEnum>();

            //fobj.InterfaceType = fr.InterfaceType.ToEnumSafe<InterfaceTypeEnum>();
            //fobj.InterfaceTypeUnit = fr.InterfaceTypeUnit.ToEnumSafe<InterfaceTypeUnitEnum>();

            //fobj.InterfaceCategory = fr.InterfaceCategory.ToEnumSafe<InterfaceCategoryEnum>();
            ////if InterfaceCategory == Ethernet_Layer_2
            //fobj.SubcategoryOfInterfaceCategory = fr.SubcategoryOfInterfaceCategory.ToEnumSafe<InterfaceEthernetLayer2SubCategoryEnum>();
            //fobj.ClientVLANID = fr.ClientVLANID;

            //fobj.LastMileBy = fr.LastMileBy.ToEnumSafe<LastMileByEnum>();
            ////If LastMileBy == SCL
            //fobj.LastMileServiceTypeOfLocationA = fr.LastMileServiceTypeOfLocationA.ToEnumSafe<LastMileServiceTypeEnum>();
            //fobj.LastMileImplementationTypeOfLocationA = fr.LastMileImplementationTypeOfLocationA.ToEnumSafe<LastMileImplementationTypeEnum>();

            //fobj.LastMileServiceTypeOfLocationB = fr.LastMileServiceTypeOfLocationB.ToEnumSafe<LastMileServiceTypeEnum>();
            //fobj.LastMileImplementationTypeOfLocationB = fr.LastMileImplementationTypeOfLocationB.ToEnumSafe<LastMileImplementationTypeEnum>();

            ////IsPossible

            //fobj.IsPossibleWithExistingInterfaceForLocationA = PossibleNotPossibleEnum.Possible; //fr.IsPossibleWithExistingInterfaceForLocationA.ToEnumSafe<PossibleNotPossibleEnum>(); 
            //fobj.IsPossibleWithExistingInterfaceForLocationB = PossibleNotPossibleEnum.Possible; //fr.IsPossibleWithExistingInterfaceForLocationB.ToEnumSafe<PossibleNotPossibleEnum>();

            //fobj.IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType = PossibleNotPossibleEnum.Possible; //fr.IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType.ToEnumSafe<PossibleNotPossibleEnum>();
            //fobj.IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType = PossibleNotPossibleEnum.Possible; //fr.IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType.ToEnumSafe<PossibleNotPossibleEnum>();

            //fobj.IsPossibleLastMileServiceTypeOfLocationBBySelectedServiceType = PossibleNotPossibleEnum.Possible; //fr.IsPossibleLastMileServiceTypeOfLocationBBySelectedServiceType.ToEnumSafe<PossibleNotPossibleEnum>();
            //fobj.IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType = PossibleNotPossibleEnum.Possible; //fr.IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType.ToEnumSafe<PossibleNotPossibleEnum>();

            //fobj.IsInterfaceTypePossible = PossibleNotPossibleEnum.Possible;
            //fobj.IsInterfacecategoryPossible = PossibleNotPossibleEnum.Possible;

            //fobj.IsPossibleWithSelectedConnectionType = PossibleNotPossibleEnum.Possible; //fr.IsPossibleWithSelectedConnectionType.ToEnumSafe< PossibleNotPossibleEnum>();
            //fobj.IsServicePossibleWithSelectedServiceType = PossibleNotPossibleEnum.Possible; //fr.IsServicePossibleWithSelectedServiceType.ToEnumSafe<PossibleNotPossibleEnum>();
            //fobj.IsRequiredCapacityDeliveryPossible = fobj.IsRequiredCapacityDeliveryPossible;

            //fobj.KAMRemarks = fr.KAMRemarks;
            //fobj.PlanningRemarks = fr.PlanningRemarks;


            if (fr.FeasiblityType == "Active")
            {
                ViewBag.Title = "Final Planning";
                tempview = "ActiveFinalPlan";
            }
            else
            {
                ViewBag.Title = "Final Planning";
                tempview = "PassiveFinalPlan";
            }

            //FeasibilityViewModel fobj = new FeasibilityViewModel();

            return View(tempview, fobj);
        }

        public JsonResult SaveFinalPlan(FinalPlanViewModel finalplanobj)
        {

            return Json("Final Plan sent successfull", JsonRequestBehavior.AllowGet);

        }


    }
}