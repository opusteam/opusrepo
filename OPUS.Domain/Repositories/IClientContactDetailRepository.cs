using OPUS.Domain.Entities.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain.Repositories
{
    public interface IClientContactDetailRepository : IRepository<ContactDetail>
    {
          void AddClientContacDetail(List<ContactDetail> contactdetail);
    }
}
