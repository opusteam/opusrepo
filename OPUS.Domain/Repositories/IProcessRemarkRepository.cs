using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain.Repositories
{
    public interface IProcessRemarkRepository : IRepository<ProcessRemark>
    {
        void AddProcessRemarks(List<ProcessRemark> ListOfProcessRemarks);
  
    }
}
