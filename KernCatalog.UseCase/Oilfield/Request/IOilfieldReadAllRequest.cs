namespace KernCatalog.UseCase;

using Core;

/// <summary>
/// Запрос для получения всех <see cref="OilfieldEntity"/>.
/// </summary>
public interface IOilfieldReadAllRequest
{
    /// <summary>
    /// Выполнить.
    /// </summary>
    /// <returns>список месторождений.</returns>
    public ValueTask<IReadOnlyCollection<OilfieldEntity>> ExecuteAsync();
}
