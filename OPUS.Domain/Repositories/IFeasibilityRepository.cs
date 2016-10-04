using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain.Repositories
{
    public interface IFeasibilityRepository: IRepository<Feasibility>
    {
        Feasibility FindFeasibilityByClientId(int ClientId);
        List<Feasibility> FindAllFeasibilityByKamId(string KamId);
        List<Feasibility> FindAllFeasibilityForPlanningSLA();
    }
}
