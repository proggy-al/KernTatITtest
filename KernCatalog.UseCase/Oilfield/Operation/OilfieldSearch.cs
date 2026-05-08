using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

using KernCatalog.Core;

/// <summary>
/// Поиск <see cref="OilfieldEntity"/> по фильтру.
/// </summary>
public class OilfieldSearch : UcOperationInOut<OilfieldSearch.Filter, IReadOnlyCollection<OilfieldEntity>>,
    IUcOperationDataSetInfo<DataSetInfo>
{
    /// <summary><inheritdoc/></summary>
    public DataSetInfo DataSetInfo { get; } = new();

    /// <summary>
    /// Создать <see cref="OilfieldSearch"/>.
    /// </summary>
    /// <param name="dataIn">Входные данные.</param>
    public OilfieldSearch(Filter dataIn) : base(dataIn)
    {
    }

    /// <summary>Фильтр.</summary>
    public record Filter
    { 
        /// <summary>Наименование.</summary>
        public string? Oilfieldnaim { get; set; }
        /// <summary>Лимит.</summary>
        public int? Limit { get; set; }
        /// <summary>Смещение.</summary>
        public int? Offset { get; set; }
    }
}
