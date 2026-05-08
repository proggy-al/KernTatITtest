// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.UseCase;


using Core;
using Microsoft.Extensions.DependencyInjection;
using Tn.Sdk;
using Tn.Sdk.UseCase;

/// <summary>Конфигурация <see cref="NgduEntity"/>.</summary>
internal class NgduConfiguration : IConfigurationDi
{

	void IConfigurationDi.Configure(IServiceCollection services)
	{
		services.UcRegisterOperation<NgduCreateOne, NgduCreateOneHandler>();
		services.UcRegisterOperation<NgduCreateMany, NgduCreateManyHandler>();
		services.UcRegisterOperation<NgduReadOne, NgduReadOneHandler>();
		services.UcRegisterOperation<NgduReadMany, NgduReadManyHandler>();
		services.UcRegisterOperation<NgduUpdateOne, NgduUpdateOneHandler>();
		services.UcRegisterOperation<NgduUpdateMany, NgduUpdateManyHandler>();
		services.UcRegisterOperation<NgduDeleteOne, NgduDeleteOneHandler>();
		services.UcRegisterOperation<NgduDeleteMany, NgduDeleteManyHandler>();

        services.UcRegisterOperation<NgduReadAll, NgduReadAllHandler>();
        services.UcRegisterOperation<NgduSearch, NgduSearchHandler>();
    }
}
