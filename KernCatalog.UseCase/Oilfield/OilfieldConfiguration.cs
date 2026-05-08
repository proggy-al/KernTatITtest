// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.UseCase;

using Core;
using Microsoft.Extensions.DependencyInjection;
using Tn.Sdk;
using Tn.Sdk.UseCase;

/// <summary>Конфигурация <see cref="OilfieldEntity"/>.</summary>
internal class OilfieldConfiguration : IConfigurationDi
{

	void IConfigurationDi.Configure(IServiceCollection services)
	{
		services.UcRegisterOperation<OilfieldCreateOne, OilfieldCreateOneHandler>();
		services.UcRegisterOperation<OilfieldCreateMany, OilfieldCreateManyHandler>();
		services.UcRegisterOperation<OilfieldReadOne, OilfieldReadOneHandler>();
		services.UcRegisterOperation<OilfieldReadMany, OilfieldReadManyHandler>();
		services.UcRegisterOperation<OilfieldUpdateOne, OilfieldUpdateOneHandler>();
		services.UcRegisterOperation<OilfieldUpdateMany, OilfieldUpdateManyHandler>();
		services.UcRegisterOperation<OilfieldDeleteOne, OilfieldDeleteOneHandler>();
		services.UcRegisterOperation<OilfieldDeleteMany, OilfieldDeleteManyHandler>();

        services.UcRegisterOperation<OilfieldReadAll, OilfieldReadAllHandler>();
        services.UcRegisterOperation<OilfieldSearch, OilfieldSearchHandler>();
    }
}
