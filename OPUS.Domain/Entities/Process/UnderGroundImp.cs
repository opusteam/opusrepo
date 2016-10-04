using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class UnderGroundImp
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int FinalPlanId { get; set; }
        public string FromOHType { get; set; }
        public string ToOHType  { get; set; }
        public string FromSiteOHODFInfo { get; set; }
        public string PocOHColor { get; set; }
        public string ToSiteOHODFInfo { get; set; }
        public string ToPOCOHColor { get; set; }
        public double OTDRDistance { get; set; }
        public double SpanLossDB { get; set; }
        public bool HasShortPiece { get; set; }
        public string Remarks { get; set; }

    }
}
