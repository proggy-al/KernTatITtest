using KernCatalog.UseCase;
using Microsoft.Extensions.DependencyInjection;

namespace KernCatalog.Api.Rest;

/// <summary>
/// Помошник для конфигурирования приложения.
/// </summary>
/// 
public static class AppHelper
{
    /// <summary>
    /// Добавить REST API для "Каталог керна".
    /// </summary>
    /// <param name="services">Коллекция сервисов DI.</param>
    /// <returns>Коллекция сервисов DI.</returns>
    public static IServiceCollection AddKernCatalogApiRest(this IServiceCollection services)
    {
        services.AddKernCatalogUseCaseAuto();

        return services;
    }
}
