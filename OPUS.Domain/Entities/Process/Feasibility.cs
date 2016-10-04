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
    public class Feasibility
    {
        public int Id { get; set; }
        public string FeasiblityType { get; set; }
        public string KamId { get; set; }
        public int ClientId { get; set; }
        public string Requestfor { get; set; }
        public DateTime Requestdate { get; set; }
        public string ConnectivityType { get; set; }
        public string ConnectionType { get; set; }
        public string IsPossibleWithSelectedConnectionType { get; set; }
        public string AddressOfClientLocationA { get; set; }
        public string LatitudeOfClientLocationA { get; set; }
        public string LongitudeOfClientLocationA { get; set; }
        public string AddressOfClientLocationB { get; set; }
        public string LatitudeOfClientLocationB { get; set; }
        public string LongitudeOfClientLocationB { get; set; }
        //SCL POP
        public string AddressOfSCLPOPLocationA { get; set; }
        public string LatitudeOfSCLPOPLocationA { get; set; }
        public string LongitudeOfSCLPOPLocationA { get; set; }
        public string AddressOfSCLPOPLocationB { get; set; }
        public string LatitudeOfSCLPOPLocationB { get; set; }
        public string LongitudeOfSCLPOPLocationB { get; set; }

        public string IsExistingInterfaceForLocationA { get; set; }
        public string IsPossibleWithExistingInterfaceForLocationA { get; set; }
        public string IsExistingInterfaceForLocationB { get; set; }
        public string IsPossibleWithExistingInterfaceForLocationB { get; set; }
        public string ServiceType { get; set; }
        public string IsServicePossibleWithSelectedServiceType { get; set; }
        public int RequiredCapacityQuantity { get; set; }
        public string RequiredCapacityUnit { get; set; }
        public string IsRequiredCapacityDeliveryPossible { get; set; }
        public string InterfaceType { get; set; }
        public string InterfaceTypeUnit { get; set; }
        public string IsInterfaceTypePossible { get; set; }
        public string InterfaceCategory { get; set; }
        public string SubcategoryOfInterfaceCategory { get; set; }
        public string ClientVLANID { get; set; }
        public string IsInterfacecategoryPossible { get; set; }
        public string LastMileBy { get; set; }
        public string LastMileServiceTypeOfLocationA { get; set; }
        public string IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType { get; set; }
        public string LastMileImplementationTypeOfLocationA { get; set; }
        public string IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType { get; set; }
        public string LastMileServiceTypeOfLocationB { get; set; }
        public string IsPossibleLastMileServiceTypeOfLocationBBySelectedServiceType { get; set; }
        public string LastMileImplementationTypeOfLocationB { get; set; }
        public string IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType { get; set; }
        public string Status { get; set; }
        public string SLAtype { get; set; }
        public string KAMRemarks { get; set; }
        //public string KAMWorkOrderRemarks { get; set; }
        public string CancelReason { get; set; }
        public string PlanningRemarks { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
