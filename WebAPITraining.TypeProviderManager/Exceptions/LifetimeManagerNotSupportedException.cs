using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPITraining.TypeProviderManager.Exceptions
{
    public class LifetimeManagerNotSupportedException : Exception
    {
        public LifetimeManagerNotSupportedException(TypeLifeTime typeLifeTime)
            : base($"No life time manager exists for the specified typeLifeTime: {typeLifeTime}") { }
    }
}
