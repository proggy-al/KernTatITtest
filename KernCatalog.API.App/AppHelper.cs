using KernCatalog.Infra.PostgreSql;
using Microsoft.EntityFrameworkCore;

using Tn.Sdk;
using Tn.Sdk.Dal;
using Tn.Sdk.Dal.PostgreSql;
using Tn.Sdk.Localization;

namespace KernCatalog.Api.App;

/// <summary>
/// Помощник для конфигурирования приложения.
/// </summary>
public static class AppHelper
{
    /// <summary>
    /// Добавить инфраструктуру PostgreSql в качестве БД для организационной структуры.
    /// </summary>
    /// <param name="services">Коллекция сервисов DI.</param>
    /// <param name="configuration">Конфигурация.</param>
    /// <param name="dataContextConfigPath">Путь в конфигурации для контекста данных.</param>
    /// <exception cref="CoreException">Ошибка.</exception>
    public static IServiceCollection AddMainDataContext(
        this IServiceCollection services,
        IConfiguration configuration,
        string dataContextConfigPath)
    {
        services.AddMainDataContextOption(opt =>
        {
            configuration.Bind(dataContextConfigPath, opt.ConnectionConfig);
        });

        services.AddDataContextScoped<IKernCatalogDataContext, AppDataContext>();
        services.AddKernCatalogPostgreSql();

        return services;
    }

    /// <summary>
    /// Добавить параметры соединения с PostgreSql.
    /// </summary>
    /// <param name="services">Коллекция сервисов DI.</param>
    /// <param name="pgOptionsAction">Конфигурация соединения с БД.</param>
    public static IServiceCollection AddMainDataContextOption(
        this IServiceCollection services,
        Action<IPostgreSqlOptions> pgOptionsAction)
    {
        var dcBuilder = new DataContextOptionsBuilder<AppDataContext>();
        dcBuilder
            .ConfigurePostgreSqlOptions(opt => pgOptionsAction(opt))
            .ConfigureOrgStructure()
            .UseSnakeNameStyle();

        services.AddSingleton(dcBuilder.Options);
        return services;
    }

    /// <summary>
    /// Добавить локализацию в приложение.
    /// </summary>
    /// <param name="services">Коллекция сервисов DI.</param>
    /// <param name="configuration">Конфигурация.</param>
    /// <param name="dbConnectionStringConfigPath">Путь к строке соединения в конфигурации.</param>
    /// <exception cref="CoreException">Ошибка.</exception>
    public static void AddMainLocalization(
        this IServiceCollection services,
        IConfiguration configuration,
        string dbConnectionStringConfigPath)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        var localizationDbConnection = configuration[dbConnectionStringConfigPath];
        if (string.IsNullOrEmpty(localizationDbConnection))
            throw new CoreException($"Configuration section '{dbConnectionStringConfigPath}' is not set.");

        services.AddDbContext<LocalizationDbContext>(
            opt => opt.UseNpgsql(localizationDbConnection).UseSnakeCaseNamingConvention()
        );
        services.AddEfLocalizationStorage<LocalizationDbContext>();
        services.AddLocalizationStorageFactory<EfLocalizationStorage<LocalizationDbContext>>();
        services.AddLocalizersWithStorage();
    }
}
