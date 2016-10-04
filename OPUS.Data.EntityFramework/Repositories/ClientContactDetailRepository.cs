using OPUS.Domain;
using OPUS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Data.EntityFramework.Repositories
{
    internal class ClientContactDetailRepository : Repository<ContactDetail>, IClientContactDetailRepository
    {
        internal ClientContactDetailRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public void AddClientContacDetail(List<ContactDetail> contactdetail)
        {
            Set.AddRange(contactdetail);
        }
    }
}
