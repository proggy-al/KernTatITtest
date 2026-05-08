using KernCatalog.Core;

namespace KernCatalog.UseCase;

/// <summary>
/// Запрос для получения всех <see cref="WelldataEntity"/>.
/// </summary>
public interface IWelldataReadAllRequest
{
    /// <summary>
    /// Выполнить.
    /// </summary>
    /// <returns>список скважин.</returns>
    public ValueTask<IReadOnlyCollection<WelldataEntity>> ExecuteAsync();
}
