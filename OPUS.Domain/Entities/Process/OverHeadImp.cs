using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class OverHeadImp
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int FinalPlanId { get; set; }
        public string FromSiteId { get; set; }
        public string FromSiteAddress { get; set; }
        public string FromSiteCableId { get; set; }
        public string FromSiteOHCoreColor { get; set; }
        public string FromSiteRxPower { get; set; }
        public string ToSiteId { get; set; }
        public string ToSiteAddress { get; set; }
        public string ToSiteCableId { get; set; }
        public string ToSiteOHCoreColor { get; set; }
        public string ToSiteRxPower { get; set; }
        public double OTDRDistance { get; set; }
        public double SpanLoss { get; set; }
        public string Remarks { get; set; }
    }
}
