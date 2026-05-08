using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

using Core;

/// <summary>
/// Получить список всех <see cref="NgduEntity"/>.
/// </summary>
public class NgduReadAll :
    UcOperationOut<IReadOnlyCollection<NgduEntity>>,
    IUcOperationDataSetInfo<DataSetInfo>
{
    /// <inheritdoc/>
    public DataSetInfo DataSetInfo { get; } = new();
}
