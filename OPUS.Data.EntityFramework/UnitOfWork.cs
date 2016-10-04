using OPUS.Data.EntityFramework.Repositories;
using OPUS.Domain;
using OPUS.Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace OPUS.Data.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields
        private readonly ApplicationDbContext _context;
        private IExternalLoginRepository _externalLoginRepository;
        private IRoleRepository _roleRepository;
        private IUserRepository _userRepository;
        private IClientRepository _clientRepository;
        private IFeasibilityRepository _feasibilityRepository;
        private IClientContactDetailRepository _clientContactDetailRepository;
        private IProcessRemarkRepository _processRemarkRepository;
        private IAssignedSLARepository _assignedSLARepository;
        private IHolidaySettingRepository _holidaysettingRepository;
        private IcancelReasonRepository _cancelReasonRepository;

        private IWorkOrderRepository _workorderRepository;
        private IWorkOrderDetailRepository _workorderDetailRepository;
        private IFinalPlanRepository _finalplanRepository;

        #endregion

        #region Constructors
        public UnitOfWork()
        {
            _context = new ApplicationDbContext();
        }
        #endregion

        #region IUnitOfWork Members
        public IExternalLoginRepository ExternalLoginRepository
        {
            get { return _externalLoginRepository ?? (_externalLoginRepository = new ExternalLoginRepository(_context)); }
        }

        public IRoleRepository RoleRepository
        {
            get { return _roleRepository ?? (_roleRepository = new RoleRepository(_context)); }
        }

        public IUserRepository UserRepository
        {
            get { return _userRepository ?? (_userRepository = new UserRepository(_context)); }
        }

        public IClientRepository ClientRepository
        {
            get { return _clientRepository ?? (_clientRepository = new ClientRepository(_context)); }
        }

        public IFeasibilityRepository FeasibilityRepository
        {
            get { return _feasibilityRepository ?? (_feasibilityRepository = new FeasibilityRepository(_context)); }
        }

        public IClientContactDetailRepository ClientContactDetailRepository
        {
            get { return _clientContactDetailRepository ?? (_clientContactDetailRepository = new ClientContactDetailRepository(_context)); }
        }

        public IProcessRemarkRepository ProcessRemarkRepository
        {
            get { return _processRemarkRepository ?? (_processRemarkRepository = new ProcessRemarkRepository(_context)); }
        }

        public IAssignedSLARepository AssignedSLARepository
        {
            get { return _assignedSLARepository ?? (_assignedSLARepository = new AssignedSLARepository(_context)); }
        }

        public IHolidaySettingRepository HolidaySettingRepository
        {
            get { return _holidaysettingRepository ?? (_holidaysettingRepository = new HolidaySettingRepository(_context)); }
        }

        public IcancelReasonRepository CancelReasonRepository
        {
            get { return _cancelReasonRepository ?? (_cancelReasonRepository = new  CancelReasonRepository(_context)); }
        }

        public IWorkOrderRepository WorkOrderRepository
        {
            get { return _workorderRepository ?? (_workorderRepository = new WorkOrderRepository(_context)); }
        }
        public IWorkOrderDetailRepository WorkOrderDetailRepository
        {
            get { return _workorderDetailRepository ?? (_workorderDetailRepository = new WorkOrderDetailRepository(_context)); }
        }

        public IFinalPlanRepository FinalPlanRepository
        {
            get { return _finalplanRepository ?? (_finalplanRepository = new FinalPlanRepository(_context)); }
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            try
            {
                return _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
        #endregion

        #region IDisposable Members
        public void Dispose()
        {
            _externalLoginRepository = null;
            _roleRepository = null;
            _userRepository = null;
            _context.Dispose();
        }
        #endregion
    }
}