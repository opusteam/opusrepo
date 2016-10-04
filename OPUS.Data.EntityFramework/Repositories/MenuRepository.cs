using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPUS.Domain;
using OPUS.Domain.Repositories;

namespace OPUS.Data.EntityFramework.Repositories
{
    internal class MenuRepository : Repository<Menu>, IMenuRepository
    {

        internal MenuRepository(ApplicationDbContext context)
            : base(context)
        {
        }
        public List<Menu> GetMenuByUserName(string username)
        {
            return Set.ToList();
        }
    }
}
