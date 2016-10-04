using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OPUS.Domain
{
    public class FinalPlanViewModel
    {
        public int FId { get; set; }
        public int WorkOrderId { get; set; }
        [DisplayName("Feasibility Type")]
        public string FeasiblityType { get; set; }
        
        [DisplayName("Client Name")]
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        [DisplayName("Request For")]
        public string Requestfor { get; set; }

        [DisplayName("Connectivity Type")]
        public string ConnectivityType { get; set; }
        [DisplayName("Connection Type")]
        public string ConnectionType { get; set; }
       
        [DisplayName("Address-A")]
        public string AddressOfClientLocationA { get; set; }
        [DisplayName("Latitude-A")]
        public string LatitudeOfClientLocationA { get; set; }
        [DisplayName("Longitude-A")]
        public string LongitudeOfClientLocationA { get; set; }
        [DisplayName("Address-B")]
        public string AddressOfClientLocationB { get; set; }
        [DisplayName("Latitude-B")]
        public string LatitudeOfClientLocationB { get; set; }
        [DisplayName("Longitude-B")]
        public string LongitudeOfClientLocationB { get; set; }

        //SCL POP Location
        [DisplayName("Address-A")]
        public string AddressOfSCLPOPLocationA { get; set; }
        [DisplayName("Latitude-A")]
        public string LatitudeOfSCLPOPLocationA { get; set; }
        [DisplayName("Longitude-A")]
        public string LongitudeOfSCLPOPLocationA { get; set; }
        [DisplayName("Address-B")]
        public string AddressOfSCLPOPLocationB { get; set; }
        [DisplayName("Latitude-B")]
        public string LatitudeOfSCLPOPLocationB { get; set; }
        [DisplayName("Longitude-B")]
        public string LongitudeOfSCLPOPLocationB { get; set; }

        [DisplayName("Is Exists Interface?")]
        public string IsExistingInterfaceForLocationA { get; set; }

        public string IsExistingInterfaceForLocationB { get; set; }
        
        [DisplayName("Service Type")]
        public string ServiceType { get; set; }        

        [DisplayName("Capacity Required")]
        public int RequiredCapacityQuantity { get; set; }
        [DisplayName("Unit")]
        public string RequiredCapacityUnit { get; set; }

        [DisplayName("Interface Type")]
        public string InterfaceType { get; set; }

        [DisplayName("Unit")]
        public string InterfaceTypeUnit { get; set; }        

        [DisplayName("Interface Category")]
        public string InterfaceCategory { get; set; }
        public string SubcategoryOfInterfaceCategory { get; set; }
        public string ClientVLANID { get; set; }
        
        [DisplayName("Last Mile By")]
        public string LastMileBy { get; set; }
        [DisplayName("Sevice Type")]
        public string LastMileServiceTypeOfLocationA { get; set; }
        
        [DisplayName("Implementation Type")]
        public string LastMileImplementationTypeOfLocationA { get; set; }
        
        [DisplayName("Sevice Type")]
        public string LastMileServiceTypeOfLocationB { get; set; }
        
        [DisplayName("Implementation Type")]
        public string LastMileImplementationTypeOfLocationB { get; set; }
                
        //Remarks
        [DisplayName("Feasibility Remarks")]
        public string KAMRemarks { get; set; }
        [DisplayName("Work Order Remarks")]
        public string KAMWorkOrderRemarks { get; set; }
        [DisplayName("Cancel Remarks")]
        public string CancelRemarks { get; set; }
        [DisplayName("Planning Remarks")]
        public string PlanningRemarks { get; set; }

        //Work Order fields
        [DisplayName("From Cable Id")]
        public string FromCableId { get; set; }
        [DisplayName("To Cable Id")]
        public string ToCableId { get; set; }
        [DisplayName("From Core Color")]
        //public string FromCoreColor { get; set; }
        public string FromCoreColor { get; set; }
        [DisplayName("To Core Color")]
        //public string ToCoreColor { get; set; }
        public string ToCoreColor { get; set; }
        public DateTime ConfirmationDate { get; set; }


        //Final Planning fields
        [DisplayName("Link ID")]
        public string LinkId { get; set; }
        [DisplayName("From POC/Site")]
        public string FromPOC { get; set; }
        [DisplayName("To POC/Site")]
        public string ToPOC { get; set; }

        [DisplayName("From Core ID")]
        public string FromCoreID { get; set; }
        [DisplayName("To Core ID")]
        public string ToCoreId { get; set; }
        [DisplayName("Link Budget")]
        public string LinkBLinkBudget { get; set; }
        
        public string Remarks { get; set; }

        [DisplayName("Underground Doc")]
        public bool UGdoc { get; set; }
        [DisplayName("Overhead Doc")]
        public bool OHdoc { get; set; }
        [DisplayName("I & C Doc")]
        public bool InCdoc { get; set; }

        List<HttpPostedFileBase> UGFiles { get; set; }
        List<HttpPostedFileBase> OHFiles { get; set; }
        List<HttpPostedFileBase> InCFiles { get; set; }

        public string UGFilesToBeUploaded { get; set; }
        public string OHFilesToBeUploaded { get; set; }
        public string InCFilesToBeUploaded { get; set; }


    }
}
