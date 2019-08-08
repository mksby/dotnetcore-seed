using Autofac;
using Web.Api.Core.Interfaces.UseCases;
using Web.Api.Core.Mapping;
using Web.Api.Core.UseCases;

namespace Web.Api.Core
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegisterUserUseCase>().As<IRegisterUserUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<LoginUseCase>().As<ILoginUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<ExchangeRefreshTokenUseCase>().As<IExchangeRefreshTokenUseCase>().InstancePerLifetimeScope();

            builder.RegisterType<DistrictsCoordinatesUseCase>().As<IDistrictsCoordinatesUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<DistrictsMapper>().As<DistrictsMapper>().InstancePerLifetimeScope();
        }
    }
}
