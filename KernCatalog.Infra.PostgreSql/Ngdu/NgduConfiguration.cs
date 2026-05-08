// Сгенерировано при помощи утилиты Tn.Sdk.Cli.

namespace KernCatalog.Infra.PostgreSql;

using Core;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tn.Sdk;
using Tn.Sdk.Dal.EfCore;
using Tn.Sdk.Dal.PostgreSql;
using UseCase;

/// <summary>Конфигурация для <see cref="NgduDb"/>.</summary>
internal class NgduConfiguration : IPostgreSqlConfiguration, IEfEntityConfiguration, IMapperConfiguration, IConfigurationDi
{

	void IPostgreSqlConfiguration.Configure(IPostgreSqlOptions config)
	{
        config.MapComposite<NgduDb>(NgduDb.Model.FullName);
    }

	void IMapperConfiguration.Configure(TypeAdapterConfig config)
	{
		config.NewConfig<NgduDb, NgduEntity>().TwoWays();
    }

	void IEfEntityConfiguration.Configure(ModelBuilder builder)
	{
        var eb = builder.Entity<NgduDb>();
        eb.ToTable(NgduDb.Model.Table, NgduDb.Model.Schema);
        eb.HasKey(e => e.Uid);
    }

	void IConfigurationDi.Configure(IServiceCollection services)
	{
		services.AddTransient<INgduReadRequest, NgduCrudCmd>();
		services.AddTransient<INgduCreateRequest, NgduCrudCmd>();
		services.AddTransient<INgduUpdateRequest, NgduCrudCmd>();		
		services.AddTransient<INgduDeleteRequest, NgduCrudCmd>();

        services.AddTransient<INgduReadAllRequest, NgduReadAllCmd>();

        services.AddTransient<INgduSearchRequest, NgduSearchCmd>();
    }
}
