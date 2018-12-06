using System.Web.Http;
using Unity;
using Unity.WebApi;
using WebAPITraining.Unity;

namespace WebAPITraining.Unity
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterServices();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        public static object GetService<T>()
        {
            return GlobalConfiguration.Configuration.DependencyResolver.GetService(typeof(T));
        }
    }
}