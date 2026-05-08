using KernCatalog.Core;

namespace KernCatalog.UseCase;

/// <summary>
/// Поиск <see cref="OilsquareEntity"/> по фильтру.
/// </summary>
public interface IOilsquareSearchRequest
{
    /// <summary>
    /// Выполнить.
    /// </summary>
    /// <param name="filter">Фильтр.</param>
    /// <param name="cancellation">Токен прерывания.</param>
    /// <returns>Список <see cref="OilsquareEntity"/>.</returns>
    public ValueTask<IReadOnlyCollection<OilsquareEntity>> ExecuteAsync(
        OilsquareSearch.Filter filter, CancellationToken cancellation = default
    );
}
