using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITraining.TypeProviderManager.Exceptions;

namespace WebAPITraining.TypeProviderManager.Configuration
{
    public class TypeProviderConfigElement : ConfigurationElement
    {
        [ConfigurationProperty("ImplementedInterfaceFullyQualifiedName", IsRequired = true)]
        public string ImplementedInterfaceFullyQualifiedName
        {
            get
            {
                return (string)base["ImplementedInterfaceFullyQualifiedName"];
            }
            set
            {
                base["ImplementedInterfaceFullyQualifiedName"] = value;
            }
        }

        //public string ConcreteTypeAssemblyFullPath
        //{
        //    get
        //    {
        //        return Path.Combine(ConcreteTypeAssemblyParentFolderAbsolutePath, ConcreteTypeAssemblyName);
        //    }
        //}

        [ConfigurationProperty("ConcreteTypeAssemblyName", IsRequired = true)]
        public string ConcreteTypeAssemblyName
        {
            get
            {
                return (string)base["ConcreteTypeAssemblyName"];
            }
            set
            {
                base["ConcreteTypeAssemblyName"] = value;
            }
        }

        /// <summary>
        /// Meanwhile not supported as a config-property because an assembly-resolving in GAC is needed; Will be implemented in later phase
        /// </summary>
        //[ConfigurationProperty("ConcreteTypeAssemblyParentFolderAbsolutePath", IsRequired = false)]
        //public string ConcreteTypeAssemblyParentFolderAbsolutePath
        //{
        //    get
        //    {
        //        string configVal = null;//(string)base["ConcreteTypeAssemblyParentFolderAbsolutePath"];
        //        configVal = !string.IsNullOrEmpty(configVal) ? configVal : AppDomain.CurrentDomain.RelativeSearchPath;
        //        return configVal;
        //    }
        //    set
        //    {
        //        base["ConcreteTypeAssemblyParentFolderAbsolutePath"] = value;
        //    }
        //}

        /// <summary>
        /// Values expected: Transient, ContainerControlled, Hierarchical, PerResolve, PerThread, ExternallyControlled (as strings, not as as the corresponding enum integers)
        /// The default value is Transient. For more info - see http://www.tutorialsteacher.com/ioc/lifetime-manager-in-unity-container. 
        /// If the value provided is not as expected - a TypeProviderConfigurationException exception will be thrown specifying that the value provided is not valid for this property
        /// </summary>
        [ConfigurationProperty("ConcreteTypeLifeTime")]
        public TypeLifeTime ConcreteTypeLifeTime
        {
            get
            {
                return (TypeLifeTime)base["ConcreteTypeLifeTime"];
            }
            set
            {
                base["ConcreteTypeLifeTime"] = value;
            }
        }
    }
}
