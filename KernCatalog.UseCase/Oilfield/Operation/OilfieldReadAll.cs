using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

using Core;

/// <summary>
/// Получить список всех <see cref="OilfieldEntity"/>.
/// </summary>
public class OilfieldReadAll :
    UcOperationOut<IReadOnlyCollection<OilfieldEntity>>,
    IUcOperationDataSetInfo<DataSetInfo>
{
    /// <inheritdoc/>
    public DataSetInfo DataSetInfo { get; } = new();
}
