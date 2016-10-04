using OPUS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain.Services
{
   public interface IClientService: IGenericService<Client>
   {
        Client GetClientByName(string name);

        bool AddClientContacDetail(List<ContactDetail> contactdetail);

        List<Client> PagingList(int skip, int take);
    }
}
