using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class PlanningFeedBackOnActiveFeasibility
    {
        public int FeasibilityId { get; set; }
        public string AddressOfSCLPOPLocationA { get; set; }
        public string LatitudeOfSCLPOPLocationA { get; set; }
        public string LongitudeOfSCLPOPLocationA { get; set; }
        public string AddressOfSCLPOPLocationB { get; set; }
        public string LatitudeOfSCLPOPLocationB { get; set; }
        public string LongitudeOfSCLPOPLocationB { get; set; }
        public string IsPossibleWithExistenceInterfaceForLocationA { get; set; }
        public string IsPossibleWithExistenceInterfaceForLocationB { get; set; }
        public string IsPossibleWithSelectedInterface { get; set; }
        public string IsPossibleWithSelectedInterfaceCategory { get; set; }
        public string IsPossibleWithSelectedServiceType { get; set; }
        public string IsPossibleToDeliverRequiredCapacity { get; set; }
        public string IsPossibleLastMileSelectedServiceTypeForLocationA { get; set; }
        public string IsPossibleLastMileImplementationTypeForLocationA { get; set; }
        public string IsPossibleLastMileSelectedServiceTypeForLocationB { get; set; }
        public string IsPossibleLastMileImplementationTypeForLocationB { get; set; }
        public List<ProcessRemark> ProcessRemarks { get; set; }
        public string PlanningRemarks { get; set; }
    }
}
