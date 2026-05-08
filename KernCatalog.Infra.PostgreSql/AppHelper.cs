using Microsoft.Extensions.DependencyInjection;
using Tn.Sdk.Dal;
using Tn.Sdk;
using Tn.Sdk.Dal.EfCore;
using Tn.Sdk.Dal.PostgreSql;

namespace KernCatalog.Infra.PostgreSql;

/// <summary>
/// Помошник для конфигурирования приложения.
/// </summary>
public static class AppHelper
{
    private static readonly Configuration _configGroup = [];

    /// <summary>
    /// Добавить инфраструктуру PostgreSql в качестве БД для "Каталог керна".
    /// </summary>
    /// <param name="services">Коллекция сервисов DI.</param>
    /// <exception cref="CoreException">Ошибка.</exception>
    public static IServiceCollection AddKernCatalogPostgreSql(
        this IServiceCollection services        
    )
    {
        services.ConfigureByGroup(_configGroup);
        return services;
    }

    /// <summary>
    /// Добавить инфраструктуру PostgreSql в качестве БД для организационной структуры.
    /// </summary>
    public static DataContextOptionsBuilder<TContext> ConfigureOrgStructure<TContext>(
        this DataContextOptionsBuilder<TContext> builder)
        where TContext : DataContext, IKernCatalogDataContext
    {
        builder
            .ConfigurePostgreSqlOptions(static opt =>
                opt.AddRange(_configGroup.GetConfigurations<IPostgreSqlConfiguration>())
            )
            .ConfigureEfCore(static opt =>
                opt.AddRange(_configGroup.GetConfigurations<IEfEntityConfiguration>())
            )
            .ConfigureMapper(static opt =>
                opt.ConfigureByGroup(_configGroup)
            );
        return builder;
    }
}
