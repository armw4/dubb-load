using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using FinancialPower.Implementation;
using FinancialPowerDemo.Web.Controllers.FileUpload;

namespace FinancialPowerDemo.Configuration
{
    public static class BootStrap
    {
        public static void Start()
        {
            var container = new ContainerBuilder();

            container.RegisterAssemblyTypes(typeof(File).Assembly).AsImplementedInterfaces();

            container.RegisterControllers(typeof(FileUploadController).Assembly);

            container.RegisterModule(new AutofacWebTypesModule());

            var lifetimeScope = container.Build();
            var resolver = new AutofacDependencyResolver(lifetimeScope);

            DependencyResolver.SetResolver(resolver);
        }
    }
}
