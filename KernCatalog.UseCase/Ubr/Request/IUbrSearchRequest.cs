using KernCatalog.Core;

namespace KernCatalog.UseCase;

/// <summary>
/// Поиск <see cref="UbrEntity"/> по фильтру.
/// </summary>
public interface IUbrSearchRequest
{
    /// <summary>
    /// Выполнить.
    /// </summary>
    /// <param name="filter">Фильтр.</param>
    /// <param name="cancellation">Токен прерывания.</param>
    /// <returns>Список <see cref="UbrEntity"/>.</returns>
    public ValueTask<IReadOnlyCollection<UbrEntity>> ExecuteAsync(
        UbrSearch.Filter filter, CancellationToken cancellation = default
    );
}
