using OPUS.Domain.Entities.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain.Repositories
{
    public interface IWorkOrderDetailRepository : IRepository<WorkOrderDetail>
    {
          void AddWorkOrderDetail(List<WorkOrderDetail> wodetail);
    }
}
