using Castle.DynamicProxy;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Classroom.Core;
using Classroom.Core.Common.Contracts;
using Classroom.Data;
using Classroom.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;

namespace Classroom.WebService.Core
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            RegisterInterceptors(container);

            RegisterHttpControllers(container);

            //RegisterConfigurationHelpers(container);

            RegisterEngines(container);

            RegisterEntityFrameworkContexts(container);

            RegisterDataRepositories(container);

            RegisterCacheProviders(container);

            RegisterLoggers(container);
        }

        private void RegisterLoggers(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                .BasedOn<ILogger>()
                .WithServiceBase()
                .LifestyleSingleton()
                );
        }

        private void RegisterCacheProviders(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                .BasedOn<ICacheProvider>()
                .WithServiceBase()
                .LifestyleSingleton()
                );
        }

        private static void RegisterDataRepositories(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                .BasedOn(typeof(IRepository<,>))
                .WithService
                .AllInterfaces()
                .LifestylePerWebRequest()
                );
        }

        private static void RegisterEntityFrameworkContexts(IWindsorContainer container)
        {
            container.Register(Component.For<DbContext>()
                .ImplementedBy<ClassroomContext>()
                .LifestylePerWebRequest()
                );
        }

        private void RegisterEngines(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                .BasedOn<IBusinessEngine>()
                .WithService
                .AllInterfaces()
                .LifestylePerWebRequest()
                );
        }

        //private void RegisterConfigurationHelpers(IWindsorContainer container)
        //{
        //    container.Register(
        //        DependencyContainer.Descriptor
        //        .BasedOn<IConfigurationHelper>()
        //        .WithServiceBase()
        //        .LifestyleSingleton()
        //        );
        //}

        private void RegisterHttpControllers(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                .BasedOn<IHttpController>()
                .WithService
                .Self()
                .LifestylePerWebRequest()
                );
        }

        private void RegisterInterceptors(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                    .BasedOn<IInterceptor>()
                    .WithService
                    .Self()
                    .LifestylePerWebRequest()
                );
        }


    }
}