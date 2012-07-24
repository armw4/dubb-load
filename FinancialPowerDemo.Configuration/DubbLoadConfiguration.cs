using System;
using FinancialPowerDemo.Abstractions;
using FluentNHibernate.Automapping;

namespace FinancialPowerDemo.Configuration
{
    public class DubbLoadConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return IsEntityAndIsClass(type);
        }
       
        private static bool IsEntityAndIsClass(Type type)
        {
            var entityMarkerInterface = typeof(IEntity);

            return entityMarkerInterface.IsAssignableFrom(type) && type.IsClass;
        }
    }
}
