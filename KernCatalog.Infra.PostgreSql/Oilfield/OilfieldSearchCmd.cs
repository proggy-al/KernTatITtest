using Microsoft.Extensions.Localization;
using Tn.Sdk.Dal;

using Tn.Sdk.Dal.PostgreSql;

namespace KernCatalog.Infra.PostgreSql;

using Core;
using KernCatalog.Infra.PostgreSql;
using UseCase;

internal class OilfieldSearchCmd : SqlBaseCommand, IOilfieldSearchRequest
{
    readonly IKernCatalogDataContext Dc;

    public OilfieldSearchCmd(
        IKernCatalogDataContext dc,
        IStringLocalizer<OilfieldSearchCmd> localizer
    ) : base(dc.SqlBroker, localizer)
    {
        Dc = dc;
    }

    /// <inheritdoc/>
    public async ValueTask<IReadOnlyCollection<OilfieldEntity>> ExecuteAsync(OilfieldSearch.Filter filter, CancellationToken cancellation = default)
    {
        var bld = new PostgreSQLQueryBuilder();
        bld.SelectAdd("a.*")
            .FromAdd(OilfieldDb.Model.FullName, "a");

        if (!string.IsNullOrEmpty(filter.Oilfieldnaim))
            bld.WhereAdd(
                "lower(a.oilfieldnaim) = lower(:poilfieldnaim)",
                "and", null,
                "poilfieldnaim", filter.Oilfieldnaim
            );

        if (filter.Limit is not null)
            bld.LimitSet(":plimit", null, new() { { "plimit", filter.Limit } });

        if (filter.Offset is not null)
            bld.OffsetSet(":poffset", null, new() { { "poffset", filter.Offset } });

        var request = bld.Build();
        var dbOut = await SqlBroker.QueryAsync<OilfieldDb>(request, cancellation);
        var data = Dc.Mapper.Map<OilfieldEntity[]>(dbOut);
        return data;
    }
}
