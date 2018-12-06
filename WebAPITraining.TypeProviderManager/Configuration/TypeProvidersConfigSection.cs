using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPITraining.TypeProviderManager.Configuration
{
    /// <summary>
    /// Configures Data Access Layer's runtime loaders from specified assemblies
    /// For usage see the comment in the source code of the class
    /// </summary>
    internal class TypeProvidersConfigSection : ConfigurationSection
    {
    
        public static TypeProvidersConfigSection GetConfig()
        {
            return (TypeProvidersConfigSection)ConfigurationManager.GetSection("TypeProvidersConfigSection");
        }

        [ConfigurationProperty("AssemblyTypesProviders")]
        internal AssemblyTypesProviderCollection AssemblyTypesProviders
        {
            get
            {
                var assemblyTypesProviders = base["AssemblyTypesProviders"];
                return (AssemblyTypesProviderCollection)assemblyTypesProviders;
            }
        }
    }
}
