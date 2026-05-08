namespace KernCatalog.Infra.PostgreSql;

using Tn.Sdk.Dal;
using UseCase;
using Microsoft.Extensions.Localization;
using KernCatalog.Core;
using Tn.Sdk.Dal.PostgreSql;

internal class NgduSearchCmd : SqlBaseCommand, INgduSearchRequest
{
    readonly IKernCatalogDataContext Dc;

    public NgduSearchCmd(
        IKernCatalogDataContext dc,
        IStringLocalizer<NgduSearchCmd> localizer
    ) : base(dc.SqlBroker, localizer)
    {
        Dc = dc;
    }

    /// <inheritdoc/>
    public async ValueTask<IReadOnlyCollection<NgduEntity>> ExecuteAsync(NgduSearch.Filter filter, CancellationToken cancellation = default)
    {
        var bld = new PostgreSQLQueryBuilder();
        bld.SelectAdd("a.*")
            .FromAdd(NgduDb.Model.FullName, "a");

        if (!string.IsNullOrEmpty(filter.Ngdunaim))
            bld.WhereAdd(
                "lower(a.ngdunaim) = lower(:pngdunaim)",
                "and", null,
                "pngdunaim", filter.Ngdunaim
            );

        if (filter.Limit is not null)
            bld.LimitSet(":plimit", null, new() { { "plimit", filter.Limit } });

        if (filter.Offset is not null)
            bld.OffsetSet(":poffset", null, new() { { "poffset", filter.Offset } });

        var request = bld.Build();
        var dbOut = await SqlBroker.QueryAsync<NgduDb>(request, cancellation);
        var data = Dc.Mapper.Map<NgduEntity[]>(dbOut);
        return data;
    }
}
