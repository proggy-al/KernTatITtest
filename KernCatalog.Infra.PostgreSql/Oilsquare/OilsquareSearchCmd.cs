namespace KernCatalog.Infra.PostgreSql;

using Core;
using Microsoft.Extensions.Localization;
using Tn.Sdk.Dal.PostgreSql;
using Tn.Sdk.Dal;
using UseCase;

internal class OilsquareSearchCmd : SqlBaseCommand, IOilsquareSearchRequest
{
    readonly IKernCatalogDataContext Dc;

    public OilsquareSearchCmd(
        IKernCatalogDataContext dc,
        IStringLocalizer<OilsquareSearchCmd> localizer
    ) : base(dc.SqlBroker, localizer)
    {
        Dc = dc;
    }

    /// <inheritdoc/>
    public async ValueTask<IReadOnlyCollection<OilsquareEntity>> ExecuteAsync(OilsquareSearch.Filter filter, CancellationToken cancellation = default)
    {
        var bld = new PostgreSQLQueryBuilder();
        bld.SelectAdd("a.*")
            .FromAdd(OilsquareDb.Model.FullName, "a");

        if (!string.IsNullOrEmpty(filter.Oilsquarenaim))
            bld.WhereAdd(
                "lower(a.oilsquarenaim) = lower(:poilsquarenaim)",
                "and", null,
                "poilsquarenaim", filter.Oilsquarenaim
            );
        if (filter.Limit is not null)
            bld.LimitSet(":plimit", null, new() { { "plimit", filter.Limit } });
        if (filter.Offset is not null)
            bld.OffsetSet(":poffset", null, new() { { "poffset", filter.Offset } });

        var request = bld.Build();
        var dbOut = await SqlBroker.QueryAsync<OilsquareDb>(request, cancellation);
        var data = Dc.Mapper.Map<OilsquareEntity[]>(dbOut);
        return data;
    }
}