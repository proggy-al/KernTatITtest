namespace KernCatalog.UseCase;

using Core;

/// <summary>
/// Запрос для получения всех <see cref="OilsquareEntity"/>.
/// </summary>
public interface IOilsquareReadAllRequest
{
    /// <summary>
    /// Выполнить.
    /// </summary>
    /// <returns>список площадей.</returns>
    public ValueTask<IReadOnlyCollection<OilsquareEntity>> ExecuteAsync();
}
