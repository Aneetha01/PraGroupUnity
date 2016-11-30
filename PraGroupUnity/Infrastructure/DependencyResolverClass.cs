using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PraGroupUnity.Infrastructure
{
    public class DependencyResolverClass : IDependencyResolver
    {
        private IUnityContainer _unityContainer;

        public DependencyResolverClass(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
        }


        public object GetService(Type serviceType)
        {
            try
            {
                return _unityContainer.Resolve(serviceType);
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _unityContainer.ResolveAll(serviceType);
            }
            catch
            {
                return null;
            }
        }
    }
}