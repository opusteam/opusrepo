using OPUS.Domain.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OPUS.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        #region Properties
        IExternalLoginRepository ExternalLoginRepository { get; }
        IRoleRepository RoleRepository { get; }
        IUserRepository UserRepository { get; }

        IClientRepository ClientRepository { get;}
        IFeasibilityRepository FeasibilityRepository { get; }

        IClientContactDetailRepository ClientContactDetailRepository { get; }
        IProcessRemarkRepository ProcessRemarkRepository { get; }
        IAssignedSLARepository AssignedSLARepository { get; }
        IHolidaySettingRepository HolidaySettingRepository { get; }
        IcancelReasonRepository CancelReasonRepository { get; }

        IWorkOrderRepository WorkOrderRepository { get; }
        IWorkOrderDetailRepository WorkOrderDetailRepository { get; }
        IFinalPlanRepository FinalPlanRepository { get; }
        #endregion

        #region Methods
        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        #endregion
    }
}
