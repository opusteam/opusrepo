using OPUS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class VMHolidaySetting
    {
        [DisplayName("Weekly Holiday(Full)")]
        public WeekDaysEnum WeeklyHoliday { get; set; }
        [DisplayName("Year(Holidays will be set for this year)")]
        public int year { get; set; }

    }
}
