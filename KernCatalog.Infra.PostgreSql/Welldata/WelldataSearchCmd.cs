using Tn.Sdk;

namespace KernCatalog.Infra.PostgreSql;

using UseCase;

[EfCoreCommand<IKernCatalogDataContext, WelldataDb>()]
internal partial class WelldataSearchCmd : IWelldataSearchRequest
{
    private static IQueryable<WelldataDb> Prepare(FindContext context, WelldataSearch.Filter criteria)
    {
        var q = context.Query;
        if (criteria.Num is not null)
            q = q.Where(r => r.Wellnum == criteria.Num);
        if (criteria.NgduUid is not null)
            q = q.Where(r => r.NgduUid == criteria.NgduUid);
        if (criteria.UbrUid is not null)
            q = q.Where(r => r.UbrUid == criteria.UbrUid);
        if (criteria.Offset is not null)
            q = q.Skip(criteria.Offset.Value);
        if (criteria.Limit is not null)
            q = q.Take(criteria.Limit.Value);

        return q;
    }
}
