using OPUS.Domain;
using OPUS.Domain.Entities.Process;
using OPUS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Data.EntityFramework.Repositories
{
    internal class WorkOrderRepository : Repository<WorkOrder>, IWorkOrderRepository
    {
      
        internal WorkOrderRepository(ApplicationDbContext context)
            : base(context)
        {
        }       

        public WorkOrder FindWorkOrderById(int WorkOrderId)
        {
            return Set.FirstOrDefault(x => x.Id == WorkOrderId);
        }

       
    }
}
