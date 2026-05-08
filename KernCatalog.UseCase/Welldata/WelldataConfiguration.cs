// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.UseCase;

using Core;
using Microsoft.Extensions.DependencyInjection;
using Tn.Sdk;
using Tn.Sdk.UseCase;

/// <summary>Конфигурация <see cref="WelldataEntity"/>.</summary>
internal class WelldataConfiguration : IConfigurationDi
{

	void IConfigurationDi.Configure(IServiceCollection services)
	{
		services.UcRegisterOperation<WelldataCreateOne, WelldataCreateOneHandler>();
		services.UcRegisterOperation<WelldataCreateMany, WelldataCreateManyHandler>();
		services.UcRegisterOperation<WelldataReadOne, WelldataReadOneHandler>();
		services.UcRegisterOperation<WelldataReadMany, WelldataReadManyHandler>();
		services.UcRegisterOperation<WelldataUpdateOne, WelldataUpdateOneHandler>();
		services.UcRegisterOperation<WelldataUpdateMany, WelldataUpdateManyHandler>();
		services.UcRegisterOperation<WelldataDeleteOne, WelldataDeleteOneHandler>();
		services.UcRegisterOperation<WelldataDeleteMany, WelldataDeleteManyHandler>();

        services.UcRegisterOperation<WelldataReadAll, WelldataReadAllHandler>();
        services.UcRegisterOperation<WelldataSearch, WelldataSearchHandler>();
    }
}
