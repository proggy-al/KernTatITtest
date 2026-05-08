using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

using KernCatalog.Core;

/// <summary>
/// Поиск <see cref="OilsquareEntity"/> по фильтру.
/// </summary>
public class OilsquareSearch : UcOperationInOut<OilsquareSearch.Filter, IReadOnlyCollection<OilsquareEntity>>,
    IUcOperationDataSetInfo<DataSetInfo>
{
    /// <summary><inheritdoc/></summary>
    public DataSetInfo DataSetInfo { get; } = new();

    /// <summary>
    /// Создать <see cref="OilsquareSearch"/>.
    /// </summary>
    /// <param name="dataIn">Входные данные.</param>
    public OilsquareSearch(Filter dataIn) : base(dataIn)
    {
    }

    /// <summary>Фильтр.</summary>
    public record Filter
    { 
        /// <summary>Наименование.</summary>
        public string? Oilsquarenaim { get; set; }
        /// <summary>Лимит.</summary>
        public int? Limit { get; set; }
        /// <summary>Смещение.</summary>
        public int? Offset { get; set; }
    }
}
