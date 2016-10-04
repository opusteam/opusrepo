using OPUS.Domain.Entities.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OPUS.Domain.Repositories
{
    public interface IWorkOrderRepository : IRepository<WorkOrder>
    {
        
        WorkOrder FindWorkOrderById(int WorkOrderId);
       
    }
}
