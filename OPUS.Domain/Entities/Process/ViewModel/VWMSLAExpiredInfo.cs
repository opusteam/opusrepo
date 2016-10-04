using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class VWMSLAExpiredInfo
    {
        public int SLAId { get; set; }
        public DateTime SLAStartDateTime { get; set; }
        public DateTime SLAEndDateTime { get; set; }
        public DateTime SLAResponseDateTime { get; set; }
        public TimeSpan TimeLeftActual { get; set; }
        public TimeSpan TimePastActual { get; set; }
        public TimeSpan TimeLeftGross { get; set; }
        public TimeSpan TimePastGross { get; set; }
        public double TimeLeftInHours { get; set; }
        public string GrossTimeLeftString { get; set; }
        public double TimePastInHours { get; set; }
        public double TimeLeftInPercent { get; set; }
        public double TimePastInPercent { get; set; }
        public int WarningLevel { get; set; }
        public string Status { get; set; }
    }
}
