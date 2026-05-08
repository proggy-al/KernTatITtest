using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Tn.Sdk.Dal.EfCore;

namespace KernCatalog.Infra.PostgreSql;

using Core;
using UseCase;

internal class NgduReadAllCmd (
    IKernCatalogDataContext dc, IStringLocalizer<INgduReadAllRequest> localizer
) :
    EfCoreBaseCommandWithMapper<NgduDb>(dc.EfProvider, localizer, dc.Mapper),
    INgduReadAllRequest
{
    public async ValueTask<IReadOnlyCollection<NgduEntity>> ExecuteAsync()
    {
        var dbData = await DbSet.ToArrayAsync();
        var data = Mapper.Map<List<NgduEntity>>(dbData);
        return data;
    }
}
