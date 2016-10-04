using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class InCImp
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int FinalPlanId { get; set; }
        public string FromSiteId { get; set; }
        public string FromSiteAddress { get; set; }
        public string FromSiteRxPower { get; set; }
        public string ToSiteId { get; set; }
        public string ToSiteAddress { get; set; }
        public string ToSiteRxPower { get; set; }
        public string ConfigDetails { get; set; }
        public string MUXSwithRouterInfo { get; set; }
        public string DeviceDetails { get; set; }
        public string CommissionedBy { get; set; }
        public string Remarks { get; set; }
    }
}
