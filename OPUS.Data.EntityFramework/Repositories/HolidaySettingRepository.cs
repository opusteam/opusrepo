using OPUS.Domain;
using OPUS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Data.EntityFramework.Repositories
{
    internal class HolidaySettingRepository : Repository<Holiday>, IHolidaySettingRepository
    {
        internal HolidaySettingRepository(ApplicationDbContext context) : base(context)
        {

        }

        public void AddHolidays(List<Holiday> holidays)
        {
            Set.AddRange(holidays);
        }
    }
}
