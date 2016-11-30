using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using PraGroupUnity.Services;
using System.Web.Mvc;
using PraGroupUnity.Infrastructure;

namespace PraGroupUnity
{
    public static class IocConfigurator
    {
        public static IUnityContainer ConfigureUnityContainer()
        {
            IUnityContainer container = new UnityContainer();
            registerServices(container);

            DependencyResolver.SetResolver(new DependencyResolverClass(container));
            return container;
        }
        public static void registerServices(IUnityContainer container)
        {
            container.RegisterType<IWidgetData, WidgetDataProvider>();
            container.RegisterType<IStateData, StateDataProviderServices>();
            container.RegisterType<ICalculation, CalculationProviderService>();
        }
    }
}