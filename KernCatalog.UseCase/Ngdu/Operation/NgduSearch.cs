namespace KernCatalog.UseCase;

using Core;
using Tn.Sdk.UseCase;

/// <summary>
/// Поиск <see cref="NgduEntity"/> по фильтру.
/// </summary>
public class NgduSearch : UcOperationInOut<NgduSearch.Filter, IReadOnlyCollection<NgduEntity>>,
    IUcOperationDataSetInfo<DataSetInfo>
{
    /// <summary><inheritdoc/></summary>
    public DataSetInfo DataSetInfo { get; } = new();

    /// <summary>
    /// Создать <see cref="NgduSearch"/>.
    /// </summary>
    /// <param name="dataIn">Входные данные.</param>
    public NgduSearch(Filter dataIn) : base(dataIn)
    {
    }

    /// <summary>Фильтр.</summary>
    public record Filter
    {
        /// <summary>Наименование.</summary>
        public string? Ngdunaim { get; set; }
        /// <summary>Лимит.</summary>
        public int? Limit { get; set; }
        /// <summary>Смещение.</summary>
        public int? Offset { get; set; }
    }
}

