using Microsoft.AspNetCore.Mvc;

using Tn.Sdk.Api.Rest;
using Tn.Sdk.Localization;

namespace KernCatalog.Api.Rest;

/// <summary>
/// Контроллер для локализации.
/// </summary>
[RestApiController("localization", "Localization", "Локализация", 1)]
public class LocalizationController : RestApiController
{
    private readonly IServiceProvider _serviceProvider;

    /// <summary>
    /// Создать новый <see cref="LocalizationController"/>.
    /// </summary>
    /// <param name="serviceProvider"></param>
    public LocalizationController(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    /// <summary>
    /// Загрузка всей локализации.
    /// </summary>
    /// <returns>Результат.</returns>
    [RestApiGet("load-all-localization")]
    public Task LoadAllLocalizationStorageAsync()
    {
        LocalizationStorageHelper.LoadAllStorages(_serviceProvider);
        return Task.CompletedTask;
    }


    /// <summary>
    /// Сохранение всех не найденных значений локализации.
    /// </summary>
    /// <param name="needReload">Необходима перезагрузка значений.</param>
    /// <returns>Результат.</returns>
    [RestApiPost("save-all-non-localized-values")]
    public Task SaveAllNonLocalizedValuesAsync([FromQuery] bool needReload = true)
    {
        LocalizationStorageHelper.SaveNonLocalizedAllStorages(_serviceProvider, needReload);
        return Task.CompletedTask;
    }
}
