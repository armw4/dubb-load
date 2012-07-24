using Autofac;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;

namespace FinancialPowerDemo.Configuration
{
    public class BaseModule : Module
    {
        protected override void Load(ContainerBuilder container)
        {
            container.Register(builder =>
            {
                var sessionFactory = Fluently
                    .Configure()
                    .Database(MsSqlConfiguration.MsSql2008.ConnectionString(c => c.FromConnectionStringWithKey("DubbLoad")))
                    .Mappings(m =>
                    {
                        var autoPersistenceModel = AutoMappings.Configure();

                        m.AutoMappings.Add(autoPersistenceModel);
                    })
                    .ExposeConfiguration(cfg => cfg.SetProperty(Environment.CurrentSessionContextClass, "web"))
                    .BuildSessionFactory();

                return sessionFactory;
            })
            .As<ISessionFactory>()
            .SingleInstance();

            container.Register(builder => builder.Resolve<ISessionFactory>().GetCurrentSession()).As<ISession>();
        }
    }
}
