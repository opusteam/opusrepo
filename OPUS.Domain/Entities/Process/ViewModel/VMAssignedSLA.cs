using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class VMAssignedSLA
    {
        public int SLAId { get; set; }
        public int SLARuleId { get; set; }
        public int EventId { get; set; }
        public SLARuleSet _SLARule { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime? ResponseDatetime { get; set; }
        public string Status { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
