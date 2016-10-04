using OPUS.Domain;
using OPUS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Data.EntityFramework.Repositories
{
    internal class WorkOrderDetailRepository : Repository<WorkOrderDetail>, IWorkOrderDetailRepository
    {
        internal WorkOrderDetailRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public void AddWorkOrderDetail(List<WorkOrderDetail> wodetail)
        {
            Set.AddRange(wodetail);
        }
    }
}
