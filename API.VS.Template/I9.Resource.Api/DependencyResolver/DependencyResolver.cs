using I9.$reource$.Common;
using I9.$reource$.Business;
using I9.$reource$.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using I9.Resource.Data;

namespace I9.$resource$.Api.DependencyResolver
{
    public static class DependencyResolver
    {
        public static void Initialize(HttpConfiguration config)
        {
            buildUnityContainer(config);
        }

        private static void buildUnityContainer(HttpConfiguration config)
        {
            var container = new UnityContainer();
            registerTypes(config, container);
        }

        private static void registerTypes(HttpConfiguration config, IUnityContainer container)
        {
            
            container.RegisterType<ILogger, Logger>();
            container.RegisterType<IDomainEntity, I9.$resource$.Business.$resource$>();
            container.RegisterType<I$resource$Repository, $resource$Repository>();


            config.DependencyResolver = new UnityDependencyResolver(container);
        }

    }
}