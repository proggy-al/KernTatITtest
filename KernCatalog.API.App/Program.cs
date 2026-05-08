using Tn.Sdk.Application;
using Tn.Sdk.Application.Web;
using Tn.Sdk.Application.Web.RestApi;
using Tn.Sdk.Localization;
using KernCatalog.API.App;
using KernCatalog.Api.Rest;
using Tn.Sdk;

namespace KernCatalog.Api.App;

/// <summary>
/// Программа.
/// </summary>
public partial class Program
{
    /// <summary>
    /// Основной метод приложения.
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Конфигурация.
        var conf = builder.BuildAppConfiguration(builder.Environment);
        var appConf = conf.BindAppConfiguration<AppConfig>();

        // Локализация.
        builder.Services.AddLocalizationSupportedCultures(conf, "Localization:SupportedCultures");
        builder.Services.AddMainLocalization(conf, "Localization:Resources:DbConnection");

        // Инфраструктура.
        builder.Services.AddMainDataContext(conf, "DataContexts:DataCatalog");

        //// Логирование в памяти.
        // builder.Services.AddInMemoryLogger<Program>();

        //// Логирование в PostgreSql.
        builder.Services.AddPostgreSqlLogging(log => log
            .ConfigurePostgreSqlOptions(opt => conf.Bind("DataContexts:DataLogCatalog", opt.ConnectionConfig))
            .UseTable("sdk_log", "log")
            .AddLogger<Program>());



        // API.
        builder.Services.AddKernCatalogApiRest();

        // Web App.
        builder.Services.AddWebApp(appConf?.Web);
        // REST API.
        builder.Services.AddRestApi(appConf?.RestApi);

        var app = builder.Build();


        // 🔎 Диагностика


        var hostedServices = app.Services.GetServices<IHostedService>();
        Console.WriteLine($"✅ Зарегистрировано HostedService: {hostedServices.Count()}");
        foreach (var svc in hostedServices)
        {
            Console.WriteLine($"   - {svc.GetType().Name}");
        }


        using (var scope = app.Services.CreateScope())
        {
            try
            {
                var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                Console.WriteLine("✅ ILogger получен из контейнера");

                logger.LogInformation("🔎 Тест записи в PostgreSQL: {Time}", DateTime.Now);
                Console.WriteLine("✅ Метод LogInformation вызван");

                // Принудительная синхронизация (если логгер асинхронный)
                Task.Delay(1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Ошибка при логировании: {ex.Message}\n{ex.InnerException?.Message}");
            }
        }

        // Web App.
        app.UseWebApp(appConf?.Web);
        // REST API.
        app.UseRestApi(appConf);

        // Подключение поддержки локализации запросов по поддерживаемым культурам
        app.UseRequestLocalizationWithSupportedCultures();
        // Загрузка локализаций в хранилища
        app.Services.InitLocalizationStorages();

        app.Run();
    }
}
