using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPITraining.TypeProviderManager
{
    public enum TypeLifeTime
    {
        Transient = 0,
        ContainerControlled = 1,
        Hierarchical = 2,
        PerResolve = 3,
        PerThread = 4,
        ExternallyControlled = 5
    }
}
