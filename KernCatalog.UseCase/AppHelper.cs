using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tn.Sdk.UseCase;
using Tn.Sdk;

namespace KernCatalog.UseCase
{
    /// <summary>
    /// Помошник для конфигурирования приложения.
    /// </summary>
    public static class AppHelper
    {
        private static readonly Configuration _configuration = new();

        /// <summary>
        /// Добавить бизнес-логику для "Каталог керна".
        /// </summary>
        /// <param name="services">Коллекция сервисов DI.</param>
        /// <returns>Коллекция сервисов DI.</returns>
        public static IServiceCollection AddOrgStructureUseCase(this IServiceCollection services)
        {
            services.ConfigureByGroup(_configuration);
            return services;
        }

        /// <summary>
        /// Добавить бизнес-логику для "Каталог керна".
        /// </summary>
        /// <param name="services">Коллекция сервисов DI.</param>
        /// <returns>Коллекция сервисов DI.</returns>
        public static IServiceCollection AddKernCatalogUseCaseAuto(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            return services.UcAutoRegisterOperation(assembly);
        }
    }
}
