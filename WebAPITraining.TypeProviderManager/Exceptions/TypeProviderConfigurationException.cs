using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPITraining.TypeProviderManager.Exceptions
{
    internal class TypeProviderConfigurationException : Exception
    {
        public TypeProviderConfigurationException(string value, string configurationPropertyName)
            : base($"The value: '{value}' is not a valid value for the configuration property: {configurationPropertyName}") { }
    }
}
