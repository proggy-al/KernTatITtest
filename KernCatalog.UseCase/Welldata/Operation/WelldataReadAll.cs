using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

using Core;

/// <summary>
/// Получить список всех <see cref="WelldataEntity"/>.
/// </summary>
public class WelldataReadAll :
    UcOperationOut<IReadOnlyCollection<WelldataEntity>>,
    IUcOperationDataSetInfo<DataSetInfo>
{
    /// <inheritdoc/>
    public DataSetInfo DataSetInfo { get; } = new();
}
