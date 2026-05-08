using Microsoft.Extensions.Localization;
using Tn.Sdk.Dal;

using Tn.Sdk.Dal.PostgreSql;

namespace KernCatalog.Infra.PostgreSql;

using Core;
using UseCase;

internal class UbrSearchCmd : SqlBaseCommand, IUbrSearchRequest
{
    readonly IKernCatalogDataContext Dc;

    public UbrSearchCmd(
        IKernCatalogDataContext dc,
        IStringLocalizer<UbrSearchCmd> localizer
    ) : base(dc.SqlBroker, localizer)
    {
        Dc = dc;
    }

    /// <inheritdoc/>
    public async ValueTask<IReadOnlyCollection<UbrEntity>> ExecuteAsync(UbrSearch.Filter filter, CancellationToken cancellation = default)
    {
        var bld = new PostgreSQLQueryBuilder();
        bld.SelectAdd("a.*")
            .FromAdd(UbrDb.Model.FullName, "a");

        if (!string.IsNullOrEmpty(filter.Ubrnaim))
            bld.WhereAdd(
                "lower(a.ubrnaim) = lower(:pubrnaim)",
                "and", null,
                "pubrnaim", filter.Ubrnaim
            );
        if (filter.Limit is not null)
            bld.LimitSet(":plimit", null, new() { { "plimit", filter.Limit } });
        if (filter.Offset is not null)
            bld.OffsetSet(":poffset", null, new() { { "poffset", filter.Offset } });

        var request = bld.Build();
        var dbOut = await SqlBroker.QueryAsync<UbrDb>(request, cancellation);
        var data = Dc.Mapper.Map<UbrEntity[]>(dbOut);
        return data;
    }
}
