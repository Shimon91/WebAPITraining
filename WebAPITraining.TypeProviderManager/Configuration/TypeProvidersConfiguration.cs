using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPITraining.TypeProviderManager.Configuration
{
    internal class TypeProvidersConfiguration
    {
        private static TypeProvidersConfiguration _Instance;
        public TypeProvidersConfigSection Configuration { get; }
        public static TypeProvidersConfiguration Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock ("TypeProvidersConfiguration")
                    {
                        if (_Instance == null)
                        {
                            _Instance = new TypeProvidersConfiguration();
                        }
                    }
                }
                return _Instance;
            }
        }

        private TypeProvidersConfiguration()
        {
            Configuration = TypeProvidersConfigSection.GetConfig();
        }
    }
}
