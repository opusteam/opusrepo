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
    internal class ClientRepository : Repository<Client>, IClientRepository
    {
      
        internal ClientRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public Client FindClientByName(string clientname)
        {
            return Set.FirstOrDefault(x => x.Name == clientname);
        }

       
        public Task<Client> FindClientByNameAsync(string clientname)
        {
            return Set.FirstOrDefaultAsync(x => x.Name == clientname);
        }

        public Client FindClientById(int ClientId)
        {
            return Set.FirstOrDefault(x => x.Id == ClientId);
        }

        public List<Client> PagingList(int skip, int take)
        {
            return Set.OrderBy(x => x.Id).Skip(skip).Take(take).ToList();
        }
    }
}
