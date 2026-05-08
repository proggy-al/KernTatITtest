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

/// <summary>Конфигурация для <see cref="UbrDb"/>.</summary>
internal class UbrConfiguration : IPostgreSqlConfiguration, IEfEntityConfiguration, IMapperConfiguration, IConfigurationDi
{

	void IPostgreSqlConfiguration.Configure(IPostgreSqlOptions config)
	{		
        config.MapComposite<UbrDb>(UbrDb.Model.FullName);
    }

	void IMapperConfiguration.Configure(TypeAdapterConfig config)
	{
		config.NewConfig<UbrDb, UbrEntity>().TwoWays();
    }

	void IEfEntityConfiguration.Configure(ModelBuilder builder)
	{		
        var eb = builder.Entity<UbrDb>();
        eb.ToTable(UbrDb.Model.Table, UbrDb.Model.Schema);
        eb.HasKey(e => e.Uid);
    }

	void IConfigurationDi.Configure(IServiceCollection services)
	{
		services.AddTransient<IUbrReadRequest, UbrCrudCmd>();
		services.AddTransient<IUbrCreateRequest, UbrCrudCmd>();
		services.AddTransient<IUbrUpdateRequest, UbrCrudCmd>();
		services.AddTransient<IUbrDeleteRequest, UbrCrudCmd>();

        services.AddTransient<IUbrReadAllRequest, UbrReadAllCmd>();

        services.AddTransient<IUbrSearchRequest, UbrSearchCmd>();
    }
}
