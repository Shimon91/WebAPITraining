using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPITraining.TypeProviderManager.Configuration
{
    [ConfigurationCollection(typeof(TypeProviderConfigElement))]
    public class TypeProvidersCollection : ConfigurationElementCollection, IEnumerable<TypeProviderConfigElement>
    {
        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }

        public TypeProviderConfigElement this[int index]
        {
            get
            {
                return (TypeProviderConfigElement)BaseGet(index);
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

        public TypeProviderConfigElement this[TypeProviderConfigElement typeProvider]
        {
            get
            {
                return (TypeProviderConfigElement)BaseGet(typeProvider.ImplementedInterfaceFullyQualifiedName);
            }
            set
            {
                if (BaseGet(typeProvider.ImplementedInterfaceFullyQualifiedName) != null)
                {
                    BaseRemove(typeProvider.ImplementedInterfaceFullyQualifiedName);
                }
                BaseAdd(value);
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new TypeProviderConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((TypeProviderConfigElement)element).ImplementedInterfaceFullyQualifiedName;
        }

        protected override string ElementName => "TypeProvider";

        IEnumerator<TypeProviderConfigElement> IEnumerable<TypeProviderConfigElement>.GetEnumerator()
        {
            foreach (var item in this)
            {
                yield return (TypeProviderConfigElement)item;
            }
        }
    }
}
