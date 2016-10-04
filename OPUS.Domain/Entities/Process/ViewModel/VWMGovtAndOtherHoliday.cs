using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class VWMGovtAndOtherHoliday
    {
        public DateTime DateFrm { get; set; }
        public DateTime DateTo { get; set; }
        public int HolidayType { get; set; }
        public string Description { get; set; }
    }
}
