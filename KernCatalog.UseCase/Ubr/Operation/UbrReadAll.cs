using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

using Core;

/// <summary>
/// Получить список всех <see cref="UbrEntity"/>.
/// </summary>
public class UbrReadAll :
    UcOperationOut<IReadOnlyCollection<UbrEntity>>,
    IUcOperationDataSetInfo<DataSetInfo>
{
    /// <inheritdoc/>
    public DataSetInfo DataSetInfo { get; } = new();
}
