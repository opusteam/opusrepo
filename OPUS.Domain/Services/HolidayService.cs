using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain.Services
{
    public class HolidayService : IHolidayService
    {

        private readonly IUnitOfWork _unitOfWork;

        public HolidayService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public string Add(Holiday T)
        {
            throw new NotImplementedException();
        }

        public bool AddHolidays(List<Holiday> holidays)
        {
            try
            {
                _unitOfWork.HolidaySettingRepository.AddHolidays(holidays);
                _unitOfWork.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string Delete(Holiday T)
        {
            throw new NotImplementedException();
        }

        public List<Holiday> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Holiday T)
        {
            throw new NotImplementedException();
        }
    }
}
