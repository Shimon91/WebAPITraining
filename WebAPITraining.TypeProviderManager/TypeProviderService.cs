using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WebAPITraining.TypeProviderManager.Configuration;

namespace WebAPITraining.TypeProviderManager
{
	public static class TypeProviderService
	{
		public static List<DIPair> GetDependencyInjectionPairsList()
		{
			List<DIPair> dependencyInjectionPairsList = new List<DIPair>();
			var typeProvidersConfig = TypeProvidersConfiguration.Instance.Configuration;


			foreach (AssemblyTypesProviderConfigElement assemblyTypesProvider in typeProvidersConfig?.AssemblyTypesProviders ?? Enumerable.Empty<AssemblyTypesProviderConfigElement>())
			{
				List<Type> interfaces;
				try
				{
					var interfacesAssembly = Assembly.Load(assemblyTypesProvider.InterfacesAssemblyName);
					interfaces = interfacesAssembly.GetExportedTypes().Where(t => t.IsInterface).ToList();
				}
				catch (Exception ex)
				{
					throw new Exception($"Failed to load the assembly: {assemblyTypesProvider.InterfacesAssemblyName}", ex);
				}

				foreach (TypeProviderConfigElement typeProvider in assemblyTypesProvider.TypeProviders)
				{
					Assembly concreteTypesAssembly;
					try
					{
						concreteTypesAssembly = Assembly.Load(typeProvider.ConcreteTypeAssemblyName);
					}
					catch (Exception ex)
					{
						throw new Exception($"Failed to load the assembly: {typeProvider.ConcreteTypeAssemblyName}", ex);
					}

					var implementedInterfaceType = interfaces.Where(t => t.FullName == typeProvider.ImplementedInterfaceFullyQualifiedName).FirstOrDefault();
					if (implementedInterfaceType != null)
					{
						var concreteType = concreteTypesAssembly.GetExportedTypes().Where(subClassType => implementedInterfaceType.IsAssignableFrom(subClassType)).FirstOrDefault();
						if (concreteType != null)
						{
							dependencyInjectionPairsList.Add(new DIPair(implementedInterfaceType, concreteType, typeProvider.ConcreteTypeLifeTime));
						}
					}
				}

			}
			return dependencyInjectionPairsList;
		}
	}
}
