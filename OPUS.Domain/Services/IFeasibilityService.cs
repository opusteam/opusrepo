using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Domain.Services
{
    public interface IFeasibilityService : IGenericService<Feasibility>
    {
        Client FindClientByName(string clientname);
        Client FindClientById(int ClientId);
        List<Client> getAllClient();

        Feasibility FindFeasibilityById(int FeasibilityId);
        List<ProcessRemark> getAllPossibleNotPossibleRemarks();
        List<CancelReason> getAllCancelReasons();
        string SetSLA(AssignedSLA _sla);
        bool AddWorkOrderDetail(List<WorkOrderDetail> wodetail);
        string AddWorkOrder(WorkOrder _wo);
    }
}
