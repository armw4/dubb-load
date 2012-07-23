using Autofac;

namespace FinancialPowerDemo.Configuration
{
    public static class Container
    {
        private static readonly ContainerBuilder CurrentContainer = new ContainerBuilder();

        public static ContainerBuilder Current { get { return CurrentContainer; } }
    }
}
