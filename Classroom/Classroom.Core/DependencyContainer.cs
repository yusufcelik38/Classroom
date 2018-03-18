using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core
{
    public static class DependencyContainer
    {
        public static IWindsorContainer windsorContainer { get; private set; }
        public static FromAssemblyDescriptor Descriptor { get; set; }
        private static bool bootstrapped = false;

        public static void Bootstrap()
        {
            if(!bootstrapped)
            {
                windsorContainer = new WindsorContainer();
                var assemblyFilter = new AssemblyFilter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin"));

                Descriptor = Classes.FromAssemblyInDirectory(assemblyFilter);

                windsorContainer.Install(FromAssembly.InDirectory(assemblyFilter));
                bootstrapped = true;
            }
          


        }
        public static T Resolve<T>()
        {
            return windsorContainer.Resolve<T>();
        }
        public static object Resolve(Type type)
        {
            return windsorContainer.Resolve(type);
        }
    }
}
