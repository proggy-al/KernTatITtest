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

/// <summary>Конфигурация для <see cref="WelldataDb"/>.</summary>
internal class WelldataConfiguration : IPostgreSqlConfiguration, IEfEntityConfiguration, IMapperConfiguration, IConfigurationDi
{

	void IPostgreSqlConfiguration.Configure(IPostgreSqlOptions config)
	{		
        config.MapComposite<WelldataDb>(WelldataDb.Model.FullName);
    }

	void IMapperConfiguration.Configure(TypeAdapterConfig config)
	{
		config.NewConfig<WelldataDb, WelldataEntity>().TwoWays();
    }

	void IEfEntityConfiguration.Configure(ModelBuilder builder)
	{		
        var eb = builder.Entity<WelldataDb>();
        eb.ToTable(WelldataDb.Model.Table, WelldataDb.Model.Schema);
        eb.HasKey(e => e.Uid);
    }

	void IConfigurationDi.Configure(IServiceCollection services)
	{
		services.AddTransient<IWelldataReadRequest, WelldataCrudCmd>();
		services.AddTransient<IWelldataCreateRequest, WelldataCrudCmd>();
		services.AddTransient<IWelldataUpdateRequest, WelldataCrudCmd>();		
		services.AddTransient<IWelldataDeleteRequest, WelldataCrudCmd>();

        services.AddTransient<IWelldataReadAllRequest, WelldataReadAllCmd>();

        services.AddTransient<IWelldataSearchRequest, WelldataSearchCmd>();
    }
}
