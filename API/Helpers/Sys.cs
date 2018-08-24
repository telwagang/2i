using API.Controllers;
using API.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Helpers
{
    public static class Sys
    {
        public static StandardKernel Kernel { get; private set; }

        public static T Get<T>() 
        {
            return Kernel.Get<T>();
        }

        public static void init(StandardKernel kernel = null)
        {
            Kernel = kernel ?? new StandardKernel();

            Kernel.Bind<IContext>().To<ContextController>().InSingletonScope();
            Kernel.Bind<ISettings>().To<_2iSettings>().InSingletonScope();
            Kernel.Bind<I2iUsersController>().To<_2iUsersController>().InSingletonScope(); 

        }
    }
}
