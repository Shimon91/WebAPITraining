using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPITraining.TypeProviderManager
{
    public class DIPair
    {
        public Type ImplementedInterfaceType { get; private set; }
        public Type ConcreteType { get; private set; }
        public TypeLifeTime LifeTime { get; private set; }
        public DIPair(Type implementedInterfaceType, Type concreteType, TypeLifeTime lifeTime)
        {
            ImplementedInterfaceType = implementedInterfaceType;
            ConcreteType = concreteType;
            lifeTime = LifeTime;
        }
    }
}
