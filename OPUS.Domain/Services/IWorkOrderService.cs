using OPUS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain.Services
{
   public interface IWorkOrderService : IGenericService<WorkOrder>
   {
       
        bool AddWorkOrderDetail(List<WorkOrderDetail> wodetail);

        //List<Client> PagingList(int skip, int take);
    }
}
