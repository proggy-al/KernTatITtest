namespace KernCatalog.UseCase;

using Core;

/// <summary>
/// Запрос для получения всех <see cref="NgduEntity"/>.
/// </summary>
public interface INgduReadAllRequest
{
    /// <summary>
    /// Выполнить.
    /// </summary>
    /// <returns>список типов контактов.</returns>
    public ValueTask<IReadOnlyCollection<NgduEntity>> ExecuteAsync();
}
