using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class PlanningFeedBackOnPassiveFeasibility
    {
        public int FeasibilityId { get; set; }
        public string AddressOfSCLPOPLocationA { get; set; }
        public string LatitudeOfSCLPOPLocationA { get; set; }
        public string LongitudeOfSCLPOPLocationA { get; set; }
        public string AddressOfSCLPOPLocationB { get; set; }
        public string LatitudeOfSCLPOPLocationB { get; set; }
        public string LongitudeOfSCLPOPLocationB { get; set; }
        public string IsPossibleWithSelectedConnectionType { get; set; }
        public string IsServicePossibleWithSelectedServiceType { get; set; }
        public string IsRequiredCapacityDeliveryPossible { get; set; }
        public string IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType { get; set; }
        public string IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType { get; set; }
        public string IsPossibleLastMileServiceTypeOfLocationBBySelectedServiceType { get; set; }
        public string IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType { get; set; }
      
        public List<ProcessRemark> ProcessRemarks { get; set; }
        public string PlanningRemarks { get; set; }
    }
}
