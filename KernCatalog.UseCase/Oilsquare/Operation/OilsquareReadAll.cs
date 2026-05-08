using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

using Core;

/// <summary>
/// Получить список всех <see cref="OilsquareEntity"/>.
/// </summary>
public class OilsquareReadAll :
    UcOperationOut<IReadOnlyCollection<OilsquareEntity>>,
    IUcOperationDataSetInfo<DataSetInfo>
{
    /// <inheritdoc/>
    public DataSetInfo DataSetInfo { get; } = new();
}
