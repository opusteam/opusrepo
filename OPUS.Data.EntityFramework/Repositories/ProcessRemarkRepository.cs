using OPUS.Domain;
using OPUS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Data.EntityFramework.Repositories
{
    internal class ProcessRemarkRepository : Repository<ProcessRemark>, IProcessRemarkRepository
    {
        internal ProcessRemarkRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public void AddProcessRemarks(List<ProcessRemark> ListOfProcessRemarks)
        {
            Set.AddRange(ListOfProcessRemarks);
        }
    }
}
