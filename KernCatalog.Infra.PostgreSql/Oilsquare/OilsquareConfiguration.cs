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

/// <summary>Конфигурация для <see cref="OilsquareDb"/>.</summary>
internal class OilsquareConfiguration : IPostgreSqlConfiguration, IEfEntityConfiguration, IMapperConfiguration, IConfigurationDi
{

	void IPostgreSqlConfiguration.Configure(IPostgreSqlOptions config)
	{		
        config.MapComposite<OilsquareDb>(OilsquareDb.Model.FullName);
    }

	void IMapperConfiguration.Configure(TypeAdapterConfig config)
	{
		config.NewConfig<OilsquareDb, OilsquareEntity>().TwoWays();
    }

	void IEfEntityConfiguration.Configure(ModelBuilder builder)
	{		
        var eb = builder.Entity<OilsquareDb>();
        eb.ToTable(OilsquareDb.Model.Table, OilsquareDb.Model.Schema);
        eb.HasKey(e => e.Uid);
    }

	void IConfigurationDi.Configure(IServiceCollection services)
	{
		services.AddTransient<IOilsquareReadRequest, OilsquareCrudCmd> ();
		services.AddTransient<IOilsquareCreateRequest, OilsquareCrudCmd> ();
		services.AddTransient<IOilsquareUpdateRequest, OilsquareCrudCmd>();
		services.AddTransient<IOilsquareDeleteRequest, OilsquareCrudCmd>();

        services.AddTransient<IOilsquareReadAllRequest, OilsquareReadAllCmd>();

        services.AddTransient<IOilsquareSearchRequest, OilsquareSearchCmd>();
    }
}
