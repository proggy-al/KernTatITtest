using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Tn.Sdk.Dal.EfCore;

namespace KernCatalog.Infra.PostgreSql;

using Core;
using UseCase;

internal class OilfieldReadAllCmd(
    IKernCatalogDataContext dc, IStringLocalizer<IOilfieldReadAllRequest> localizer
) :
    EfCoreBaseCommandWithMapper<OilfieldDb>(dc.EfProvider, localizer, dc.Mapper),
    IOilfieldReadAllRequest
{
    public async ValueTask<IReadOnlyCollection<OilfieldEntity>> ExecuteAsync()
    {
        var dbData = await DbSet.ToArrayAsync();
        var data = Mapper.Map<List<OilfieldEntity>>(dbData);
        return data;
    }
}
