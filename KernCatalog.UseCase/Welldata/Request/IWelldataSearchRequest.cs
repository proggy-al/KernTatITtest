namespace KernCatalog.UseCase;

using Core;
using Tn.Sdk.UseCase;

/// <summary>
/// Поиск <see cref="WelldataEntity"/> по фильтру.
/// </summary>
public interface IWelldataSearchRequest : IEntityFindCommand<WelldataEntity, WelldataSearch.Filter>
{   
}
