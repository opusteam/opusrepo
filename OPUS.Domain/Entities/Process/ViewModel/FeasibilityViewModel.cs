using OPUS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class FeasibilityViewModel
    {

        public int FId { get; set; }

        [Required]
        [DisplayName("Feasibility Type")]
        public FeasibilityTypeEnum? FeasiblityType { get; set; }
        
        [Required]
        [DisplayName("Client Name")]
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        [Required]
        [DisplayName("Request For")]
        public RequestForEnum? Requestfor { get; set; }
        [Required]
        [DisplayName("Connectivity Type")]
        public ConnectivityTypeEnum? ConnectivityType { get; set; }
        [DisplayName("Connection Type")]
        public ConnectionTypeEnum? ConnectionType { get; set; }
        public PossibleNotPossibleEnum? IsPossibleWithSelectedConnectionType { get; set; }
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
        public YesNoEnum? IsExistingInterfaceForLocationA { get; set; }

        public YesNoEnum? IsExistingInterfaceForLocationB { get; set; }

        public PossibleNotPossibleEnum? IsPossibleWithExistingInterfaceForLocationA { get; set; }
        
        public PossibleNotPossibleEnum? IsPossibleWithExistingInterfaceForLocationB { get; set; }
        [DisplayName("Service Type")]
        public ServiceTypeEnum? ServiceType { get; set; }
        public PossibleNotPossibleEnum? IsServicePossibleWithSelectedServiceType { get; set; }

        [DisplayName("Capacity Required")]
        public int RequiredCapacityQuantity { get; set; }
        [DisplayName("Unit")]
        public CapacityRequirementUnitEnum? RequiredCapacityUnit { get; set; }

        //private PossibleNotPossibleEnum? _IsRequiredCapacityDeliveryPossible;
        //public PossibleNotPossibleEnum? IsRequiredCapacityDeliveryPossible { get { return this._IsRequiredCapacityDeliveryPossible; } set { _IsRequiredCapacityDeliveryPossible = PossibleNotPossibleEnum.Possible; } }
        public PossibleNotPossibleEnum? IsRequiredCapacityDeliveryPossible { get; set; }

        [DisplayName("Interface Type")]
        public InterfaceTypeEnum? InterfaceType { get; set; }

        [DisplayName("Unit")]
        public InterfaceTypeUnitEnum? InterfaceTypeUnit { get; set; }
        public PossibleNotPossibleEnum? IsInterfaceTypePossible { get; set; }

        [DisplayName("Interface Category")]
        public InterfaceCategoryEnum? InterfaceCategory { get; set; }
        public InterfaceEthernetLayer2SubCategoryEnum? SubcategoryOfInterfaceCategory { get; set; }
        public string ClientVLANID { get; set; }
        public PossibleNotPossibleEnum? IsInterfacecategoryPossible { get; set; }

        [DisplayName("Last Mile By")]
        public LastMileByEnum? LastMileBy { get; set; }
        [DisplayName("Sevice Type")]
        public LastMileServiceTypeEnum? LastMileServiceTypeOfLocationA { get; set; }
        public PossibleNotPossibleEnum? IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType { get; set; }
        [DisplayName("Implementation Type")]
        public LastMileImplementationTypeEnum? LastMileImplementationTypeOfLocationA { get; set; }
        public PossibleNotPossibleEnum? IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType { get; set; }
        [DisplayName("Sevice Type")]
        public LastMileServiceTypeEnum? LastMileServiceTypeOfLocationB { get; set; }
        public PossibleNotPossibleEnum? IsPossibleLastMileServiceTypeOfLocationBBySelectedServiceType { get; set; }
        [DisplayName("Implementation Type")]
        public LastMileImplementationTypeEnum? LastMileImplementationTypeOfLocationB { get; set; }
        public PossibleNotPossibleEnum? IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType { get; set; }

        //Possible-NotPossible Remarks

        public string NotPossibleRemarks_WithSelectedConnectionType { get; set; }
        public string NotPossibleRemarks_WithExistingInterfaceForLacationA { get; set; }
        public string NotPossibleRemarks_WithExistingInterfaceForLacationB { get; set; }
        public string NotPossibleRemarks_IsInterfaceTypePossible { get; set; }
        public string NotPossibleRemarks_IsInterfacecategoryPossible { get; set; }
        public string NotPossibleRemarks_WithSelectedServiceType { get; set; }
        public string NotPossibleRemarks_IsRequiredCapacityDeliveryPossible { get; set; }
        public string NotPossibleRemarks_LastMileServiceTypeOfLocationABySelectedServiceType { get; set; }
        public string NotPossibleRemarks_LastMileImplementationTypeOfLocationAForSelectedImplementationType { get; set; }
        public string NotPossibleRemarks_LastMileServiceTypeOfLocationBBySelectedServiceType { get; set; }
        public string NotPossibleRemarks_LastMileImplementationTypeOfLocationBForSelectedImplementationType { get; set; }

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
        public ColorCodeEnum? FromCoreColor { get; set; }
        [DisplayName("To Core Color")]
        //public string ToCoreColor { get; set; }
        public ColorCodeEnum? ToCoreColor { get; set; }
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
    }
}
