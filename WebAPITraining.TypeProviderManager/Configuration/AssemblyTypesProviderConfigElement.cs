using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPITraining.TypeProviderManager.Configuration
{
    public class AssemblyTypesProviderConfigElement : ConfigurationElement
    {
        //public string InterfacesAssemblyFullPath
        //{
        //    get
        //    {
        //        return Path.Combine(InterfacesAssemblyParentFolderAbsolutePath, InterfacesAssemblyName);
        //    }
        //}

        /// <summary>
        /// Meanwhile not supported as a config-property because an assembly-resolving in GAC is needed; Will be implemented in later phase
        /// </summary>
        //[ConfigurationProperty("InterfacesAssemblyParentFolderAbsolutePath", IsRequired = false)]
        //public string InterfacesAssemblyParentFolderAbsolutePath
        //{
        //    get
        //    {
        //        string configVal = null;//(string)base["InterfacesAssemblyParentFolderAbsolutePath"];
        //        configVal = !string.IsNullOrEmpty(configVal) ? configVal : AppDomain.CurrentDomain.RelativeSearchPath;
        //        return configVal;
        //    }
        //}

        [ConfigurationProperty("InterfacesAssemblyName")]
        public string InterfacesAssemblyName
        {
            get
            {
                return (string)this["InterfacesAssemblyName"];
            }
            set
            {
                this["InterfacesAssemblyName"] = value;
            }
        }

        [ConfigurationProperty("TypesProviders")]
        public TypeProvidersCollection TypeProviders
        {
            get
            {
                return (TypeProvidersCollection)base["TypesProviders"];
            }
        }
    }
}
