using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPITraining.TypeProviderManager.Configuration
{
    [ConfigurationCollection(typeof(AssemblyTypesProviderConfigElement))]
    internal class AssemblyTypesProviderCollection : ConfigurationElementCollection, IEnumerable<AssemblyTypesProviderConfigElement>
    {
        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }

        public AssemblyTypesProviderConfigElement this[int index]
        {
            get
            {
                return (AssemblyTypesProviderConfigElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        public AssemblyTypesProviderConfigElement this[AssemblyTypesProviderConfigElement assemblyTypesProvider]
        {
            get
            {
                return (AssemblyTypesProviderConfigElement)BaseGet(assemblyTypesProvider.InterfacesAssemblyName);
            }
            set
            {
                if (BaseGet(assemblyTypesProvider.InterfacesAssemblyName) != null)
                {
                    BaseRemove(assemblyTypesProvider.InterfacesAssemblyName);
                }
                BaseAdd(value);
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new AssemblyTypesProviderConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((AssemblyTypesProviderConfigElement)element).InterfacesAssemblyName;
        }

        protected override string ElementName => "AssemblyTypesProvider";

        IEnumerator<AssemblyTypesProviderConfigElement> IEnumerable<AssemblyTypesProviderConfigElement>.GetEnumerator()
        {
            foreach (var item in this)
            {
                yield return (AssemblyTypesProviderConfigElement)item;
            }
        }
    }
}
