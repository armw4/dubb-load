using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;

using FinancialPowerDemo.Core;
using FinancialPowerDemo.Web.Controllers.FileUpload;

namespace FinancialPowerDemo.Configuration
{
    public static class BootStrap
    {
        public static void Start()
        {
            Container.Current.RegisterAssemblyTypes(typeof(File).Assembly).AsImplementedInterfaces();

            Container.Current.RegisterControllers(typeof(FileUploadController).Assembly);

            Container.Current.RegisterModule(new AutofacWebTypesModule());

            var lifetimeScope = Container.Current.Build();
            var resolver = new AutofacDependencyResolver(lifetimeScope);

            DependencyResolver.SetResolver(resolver);
        }
    }
}
