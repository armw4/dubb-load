using FinancialPowerDemo.Abstractions;
using FluentNHibernate.Automapping;

namespace FinancialPowerDemo.Configuration
{
    public static class AutoMappings
    {
        public static AutoPersistenceModel Configure()
        {
            var autoPersistenceModel = AutoMap.AssemblyOf<IEntity>();

            return autoPersistenceModel;
        }
    }
}
