using Autofac;
using Autofac.Integration.Mvc;
using Practice.Business.Interfaces;
using Practice.Business.Services;
using Practice.Database;
using Practice.Database.Interfaces;
using Practice.Database.Repositories;
using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Practice.UI.IoC
{
    public class ContainerConfig
    {
        public static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // Register Repository
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(x => x.Namespace.EndsWith(".Repositories"))
                .AsImplementedInterfaces();

            // Register Services
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                   .Where(t => t.Name.EndsWith(".Service"))
                   .InstancePerLifetimeScope();

            builder.RegisterType<PracticeEntities>().AsSelf().As<DbContext>().InstancePerLifetimeScope();

            #region  Repository
            builder.RegisterGeneric(typeof(Repository<,>)).As(typeof(IRepository<>)).InstancePerLifetimeScope(); 
            builder.RegisterType<TaskRepository>().As<ITaskRepository>().InstancePerLifetimeScope(); 
            #endregion Repository

            #region Services
            //builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();
            builder.RegisterType<TaskService>().As<ITaskService>().InstancePerLifetimeScope();
            #endregion Repository

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}