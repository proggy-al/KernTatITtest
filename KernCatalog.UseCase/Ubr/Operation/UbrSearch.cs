using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

using KernCatalog.Core;

/// <summary>
/// Поиск <see cref="UbrEntity"/> по фильтру.
/// </summary>
public class UbrSearch : UcOperationInOut<UbrSearch.Filter, IReadOnlyCollection<UbrEntity>>,
    IUcOperationDataSetInfo<DataSetInfo>
{
    /// <summary><inheritdoc/></summary>
    public DataSetInfo DataSetInfo { get; } = new();

    /// <summary>
    /// Создать <see cref="UbrSearch"/>.
    /// </summary>
    /// <param name="dataIn">Входные данные.</param>
    public UbrSearch(Filter dataIn) : base(dataIn)
    {
    }

    /// <summary>Фильтр.</summary>
    public record Filter
    { 
        /// <summary>Псевдоним.</summary>
        public string? Ubrnaim { get; set; }
        /// <summary>Лимит.</summary>
        public int? Limit { get; set; }
        /// <summary>Смещение.</summary>
        public int? Offset { get; set; }
    }
}
