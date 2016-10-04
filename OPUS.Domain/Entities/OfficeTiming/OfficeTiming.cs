using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public class Holiday
    {
        public long Id { get; set; }
        [Required]
        public int holidaytype { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public string Description { get; set; }

    }

    public class HolidayType
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
    }


    public class OfficeWorkingDay
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double WorkingHours { get; set; }
       
    }

    public class OfficeHour
    {
        public int Id { get; set; }
        [Required]
        public int OfficeWorkingDayTypeId { get; set; }
        [Required]
        public TimeSpan StartAt { get; set; }    // Saving format will be like 10:00 AM or PM
        [Required]
        public TimeSpan EndAt { get; set; }     // Saving format will be like 10:00 AM or PM
        [Required]
        public DateTime DateFrom { get; set; }
        [Required]
        public DateTime DateTo { get; set; }
        public int SLAYear { get; set; }
    }

    public class HolidaySetting
    {
        public int Id { get; set; }
        public string WeeklyHoliday { get; set; }
        public string HalfWeeklyHoliDay { get; set; }
        public string Status { get; set; }
    }
}
