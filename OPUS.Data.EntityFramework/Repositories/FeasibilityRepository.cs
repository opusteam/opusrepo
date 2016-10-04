using OPUS.Domain;
using OPUS.Domain.Enums;
using OPUS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Data.EntityFramework.Repositories
{
    internal class FeasibilityRepository : Repository<Feasibility>,IFeasibilityRepository
    {
        internal FeasibilityRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public Feasibility FindFeasibilityByClientId(int ClientId)
        {
            return Set.FirstOrDefault(x => x.Id == ClientId);
        }

       public List<Feasibility> FindAllFeasibilityByKamId(string KamId)
       {
            return Set.Where(x=>x.KamId== KamId).ToList();
       }

        public List<Feasibility> FindAllFeasibilityForPlanningSLA()
        {
            return Set.Where(x => x.Status == FeasibilityStatusEnum.NewBorn.ToString() || x.Status == FeasibilityStatusEnum.WorkOrdered.ToString()).ToList();
        }
    }
}
