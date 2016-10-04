using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using OPUS.Domain;
using OPUS.Data.EntityFramework;
using OPUS.Web.Identity;
using Microsoft.AspNet.Identity;
using System;
using OPUS.Domain.Repositories;
using OPUS.Domain.Services;

namespace OPUS.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            //container.RegisterType<typeof(IRepository<>), typeof()>(new TransientLifetimeManager());
            container.RegisterType<IUserStore<IdentityUser, Guid>, UserStore>(new TransientLifetimeManager());
            container.RegisterType<RoleStore>(new TransientLifetimeManager());
            container.RegisterType<IClientService, ClientService>(new TransientLifetimeManager());
            container.RegisterType<IFeasibilityService, FeasibilityService>(new TransientLifetimeManager());
            container.RegisterType<IPlanningService, PlanningService>(new TransientLifetimeManager());
            container.RegisterType<IHolidayService, HolidayService>(new TransientLifetimeManager());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}