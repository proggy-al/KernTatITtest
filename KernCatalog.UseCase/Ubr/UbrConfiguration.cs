// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.UseCase;

using Core;
using Microsoft.Extensions.DependencyInjection;
using Tn.Sdk;
using Tn.Sdk.UseCase;

/// <summary>Конфигурация <see cref="UbrEntity"/>.</summary>
internal class UbrConfiguration : IConfigurationDi
{

	void IConfigurationDi.Configure(IServiceCollection services)
	{
		services.UcRegisterOperation<UbrCreateOne, UbrCreateOneHandler>();
		services.UcRegisterOperation<UbrCreateMany, UbrCreateManyHandler>();
		services.UcRegisterOperation<UbrReadOne, UbrReadOneHandler>();
		services.UcRegisterOperation<UbrReadMany, UbrReadManyHandler>();
		services.UcRegisterOperation<UbrUpdateOne, UbrUpdateOneHandler>();
		services.UcRegisterOperation<UbrUpdateMany, UbrUpdateManyHandler>();
		services.UcRegisterOperation<UbrDeleteOne, UbrDeleteOneHandler>();
		services.UcRegisterOperation<UbrDeleteMany, UbrDeleteManyHandler>();

        services.UcRegisterOperation<UbrReadAll, UbrReadAllHandler>();
        services.UcRegisterOperation<UbrSearch, UbrSearchHandler>();
    }
}
