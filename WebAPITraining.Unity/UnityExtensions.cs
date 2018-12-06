using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;
using WebAPITraining.TypeProviderManager;
using WebAPITraining.TypeProviderManager.Exceptions;

namespace WebAPITraining.Unity
{
    internal static class UnityExtensions
    {
        public static UnityContainer RegisterServices(this UnityContainer container)
        {
            #region Types Registeration Sample
            //container.RegisterType<ISMSProvider, ShamirSMSProvider>();
            //container.RegisterType<IEmailProvider, GmailEmailProvider>();
            //container.RegisterType<IPostcardProvider, ClalitPostcardProvider>();
            #endregion

            var diPairs = TypeProviderService.GetDependencyInjectionPairsList();
            foreach (var diPair in diPairs)
            {
                container.RegisterType(diPair.ImplementedInterfaceType, diPair.ConcreteType, GetLifeTimeManager(diPair.LifeTime));
            }
            return container;
        }

        private static LifetimeManager GetLifeTimeManager(TypeLifeTime typeLifeTime)
        {
            switch (typeLifeTime)
            {
                case TypeLifeTime.ContainerControlled:
                    {
                        return new ContainerControlledLifetimeManager();
                    }
                case TypeLifeTime.ExternallyControlled:
                    {
                        return new ExternallyControlledLifetimeManager();
                    }
                case TypeLifeTime.Hierarchical:
                    {
                        return new HierarchicalLifetimeManager();
                    }
                case TypeLifeTime.PerResolve:
                    {
                        return new PerResolveLifetimeManager();
                    }
                case TypeLifeTime.PerThread:
                    {
                        return new PerThreadLifetimeManager();
                    }
                case TypeLifeTime.Transient:
                    {
                        return new TransientLifetimeManager();
                    }
                default:
                    {
                        throw new LifetimeManagerNotSupportedException(typeLifeTime);
                    }
            }
        }
    }
}
