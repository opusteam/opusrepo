using OPUS.Domain.Entities.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OPUS.Domain.Repositories
{
    public interface IClientRepository:IRepository<Client>
    {
        Client FindClientByName(string clientname);
        Client FindClientById(int ClientId);
        Task<Client> FindClientByNameAsync(string clientname);
        List<Client> PagingList(int skip, int take);
       
       
    }
}
