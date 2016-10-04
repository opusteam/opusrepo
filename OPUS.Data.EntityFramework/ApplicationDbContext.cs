using OPUS.Data.EntityFramework.Configuration;
using OPUS.Domain;
using OPUS.Domain.Entities;
using OPUS.Domain.Entities.Process;
using System.Data.Entity;

namespace OPUS.Data.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        //internal ApplicationDbContext(string nameOrConnectionString)
        //    : base(nameOrConnectionString)
        //{
        //}

        public ApplicationDbContext() :base("name=OpusContext") { }

        internal IDbSet<User> Users { get; set; }
        internal IDbSet<Role> Roles { get; set; }
        internal IDbSet<ExternalLogin> Logins { get; set; }

        internal IDbSet<Holiday> Holidays { get; set; }
        internal IDbSet<HolidayType> HolidayTypes { get; set; }
        internal IDbSet<OfficeWorkingDay> OfficeWorkingDays { get; set; }
        internal IDbSet<OfficeHour> OfficeHours { get; set; }

        internal IDbSet<HolidaySetting> HolidaySettings { get; set; }
        public IDbSet<Client> Clients { get; set; }

        public IDbSet<ContactDetail> ContactDetails { get; set; }
        public IDbSet<Feasibility> Feasibilities { get; set; }

        public IDbSet<Menu> Menus { get; set; }

        public IDbSet<UserMenuMapping> UserMenuMappings { get; set; }

        public IDbSet<ProcessRemark> ProcessRemarks { get; set; }
        public IDbSet<SLARuleSet> SLARulesSet { get; set; }
        public IDbSet<AssignedSLA> AssignedSLAS { get; set; }
        public IDbSet<WorkOrder> WorkOrders { get; set; }
        public IDbSet<WorkOrderDetail> WorkOrderDetails { get; set; }
        public IDbSet<CancelReason> CancelReasons { get; set; }
        public IDbSet<FinalPlan> FinalPlans { get; set; }
        public IDbSet<UnderGroundImp> UnderGroundImp { get; set; }
        public IDbSet<UnderGroundAttachedFile> UnderGroundAttachedFiles { get; set; }
        public IDbSet<OverHeadImp> OverHeadImps { get; set; }
        public IDbSet<OverHeadAttachedFile> OverHeadAttachedFiles { get; set; }
        public IDbSet<InCImp> InCImps { get; set; }
        public IDbSet<InCAttachedFile> InCAttachedFiles { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new ExternalLoginConfiguration());
            modelBuilder.Configurations.Add(new ClaimConfiguration());
        }
    }
}