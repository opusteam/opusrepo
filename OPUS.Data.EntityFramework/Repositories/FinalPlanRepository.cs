using OPUS.Domain;
using OPUS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Data.EntityFramework.Repositories
{
    internal class FinalPlanRepository : Repository<FinalPlan>,IFinalPlanRepository
    {
        internal FinalPlanRepository(ApplicationDbContext context) :base(context)
        {

        }
    }
}
