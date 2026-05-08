namespace KernCatalog.UseCase;

using Core;
using Tn.Sdk.UseCase;

/// <summary>
/// Поиск <see cref="NgduEntity"/> по фильтру.
/// </summary>
public interface INgduSearchRequest
{
    /// <summary>
    /// Выполнить.
    /// </summary>
    /// <param name="filter">Фильтр.</param>
    /// <param name="cancellation">Токен прерывания.</param>
    /// <returns>Список <see cref="NgduEntity"/>.</returns>
    public ValueTask<IReadOnlyCollection<NgduEntity>> ExecuteAsync(
        NgduSearch.Filter filter, CancellationToken cancellation = default
    );
}
