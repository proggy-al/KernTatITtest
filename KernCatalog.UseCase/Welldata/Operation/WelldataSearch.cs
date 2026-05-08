using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

using Core;

/// <summary>
/// Поиск <see cref="WelldataEntity"/> по фильтру.
/// </summary>
public class WelldataSearch (WelldataSearch.Filter filter) : 
    UcOperationInOut<WelldataSearch.Filter, IReadOnlyCollection<WelldataEntity>>(filter),
    IUcOperationDataSetInfo<DataSetInfo>
{
    /// <summary><inheritdoc/></summary>
    public DataSetInfo DataSetInfo { get; } = new();


    /// <summary>Фильтр.</summary>
    public class Filter
    { 
        /// <summary>Номер.</summary>
        public string? Num { get; set; }
        /// <summary>НГДУ.</summary>
        public Guid? NgduUid { get; set; }
        /// <summary>УБР.</summary>
        public Guid? UbrUid { get; set; }
        /// <summary>Лимит.</summary>
        public int? Limit { get; set; }
        /// <summary>Смещение.</summary>
        public int? Offset { get; set; }
    }
}
