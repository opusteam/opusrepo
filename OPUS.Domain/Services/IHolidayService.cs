using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain.Services
{
    public interface IHolidayService : IGenericService<Holiday>
    {
        bool AddHolidays(List<Holiday> holidays);
      
    }
}
