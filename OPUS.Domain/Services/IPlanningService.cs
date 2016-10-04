using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain.Services
{
    public interface IPlanningService : IGenericService<Feasibility>
    {
        Feasibility FindFeasibilityById(int FeasibilityId);
        Client FindClientById(int ClientId);
        List<Client> getAllClient();
        List<ProcessRemark> getAllPossibleNotPossibleRemarks();
        bool AddRemarks(List<ProcessRemark> ListofProcessRemarks);
        List<Feasibility> FindAllFeasibilityForPlanningSLA();
        void AddFinalPlan(FinalPlan _finalPlan);
    }
}
