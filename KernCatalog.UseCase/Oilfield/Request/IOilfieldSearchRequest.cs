using KernCatalog.Core;

namespace KernCatalog.UseCase;

/// <summary>
/// Поиск <see cref="OilfieldEntity"/> по фильтру.
/// </summary>
public interface IOilfieldSearchRequest
{
    /// <summary>
    /// Выполнить.
    /// </summary>
    /// <param name="filter">Фильтр.</param>
    /// <param name="cancellation">Токен прерывания.</param>
    /// <returns>Список <see cref="OilfieldEntity"/>.</returns>
    public ValueTask<IReadOnlyCollection<OilfieldEntity>> ExecuteAsync(
        OilfieldSearch.Filter filter, CancellationToken cancellation = default
    );
}
