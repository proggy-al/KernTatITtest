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

/// <summary>Конфигурация для <see cref="OilfieldDb"/>.</summary>
internal class OilfieldConfiguration : IPostgreSqlConfiguration, IEfEntityConfiguration, IMapperConfiguration, IConfigurationDi
{

	void IPostgreSqlConfiguration.Configure(IPostgreSqlOptions config)
	{		
        config.MapComposite<OilfieldDb>(OilfieldDb.Model.FullName);
    }

	void IMapperConfiguration.Configure(TypeAdapterConfig config)
	{
		config.NewConfig<OilfieldDb, OilfieldEntity>().TwoWays();
    }

	void IEfEntityConfiguration.Configure(ModelBuilder builder)
	{		
        var eb = builder.Entity<OilfieldDb>();
        eb.ToTable(OilfieldDb.Model.Table, OilfieldDb.Model.Schema);
        eb.HasKey(e => e.Uid);
    }

	void IConfigurationDi.Configure(IServiceCollection services)
	{
		services.AddTransient<IOilfieldReadRequest, OilfieldCrudCmd>();
		services.AddTransient<IOilfieldCreateRequest, OilfieldCrudCmd>();
		services.AddTransient<IOilfieldUpdateRequest, OilfieldCrudCmd>();
		services.AddTransient<IOilfieldDeleteRequest, OilfieldCrudCmd>();

        services.AddTransient<IOilfieldReadAllRequest, OilfieldReadAllCmd>();

        services.AddTransient<IOilfieldSearchRequest, OilfieldSearchCmd>();
    }
}
