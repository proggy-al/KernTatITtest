// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.UseCase;

using Core;
using Microsoft.Extensions.DependencyInjection;
using Tn.Sdk;
using Tn.Sdk.UseCase;

/// <summary>Конфигурация <see cref="OilsquareEntity"/>.</summary>
internal class OilsquareConfiguration : IConfigurationDi
{

	void IConfigurationDi.Configure(IServiceCollection services)
	{
		services.UcRegisterOperation<OilsquareCreateOne, OilsquareCreateOneHandler>();
		services.UcRegisterOperation<OilsquareCreateMany, OilsquareCreateManyHandler>();
		services.UcRegisterOperation<OilsquareReadOne, OilsquareReadOneHandler>();
		services.UcRegisterOperation<OilsquareReadMany, OilsquareReadManyHandler>();
		services.UcRegisterOperation<OilsquareUpdateOne, OilsquareUpdateOneHandler>();
		services.UcRegisterOperation<OilsquareUpdateMany, OilsquareUpdateManyHandler>();
		services.UcRegisterOperation<OilsquareDeleteOne, OilsquareDeleteOneHandler>();
		services.UcRegisterOperation<OilsquareDeleteMany, OilsquareDeleteManyHandler>();

        services.UcRegisterOperation<OilsquareReadAll, OilsquareReadAllHandler>();
        services.UcRegisterOperation<OilsquareSearch, OilsquareSearchHandler>();
    }
}
