namespace KernCatalog.UseCase;

using Core;

/// <summary>
/// Запрос для получения всех <see cref="UbrEntity"/>.
/// </summary>
public interface IUbrReadAllRequest
{
    /// <summary>
    /// Выполнить.
    /// </summary>
    /// <returns>список УБР.</returns>
    public ValueTask<IReadOnlyCollection<UbrEntity>> ExecuteAsync();
}
