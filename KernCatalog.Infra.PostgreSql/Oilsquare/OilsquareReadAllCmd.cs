using KernCatalog.Core;
using KernCatalog.UseCase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Tn.Sdk.Dal.EfCore;

namespace KernCatalog.Infra.PostgreSql
{
    internal class OilsquareReadAllCmd(
    IKernCatalogDataContext dc, IStringLocalizer<IOilsquareReadAllRequest> localizer
) :
    EfCoreBaseCommandWithMapper<OilsquareDb>(dc.EfProvider, localizer, dc.Mapper),
    IOilsquareReadAllRequest
    {
        public async ValueTask<IReadOnlyCollection<OilsquareEntity>> ExecuteAsync()
        {
            var dbData = await DbSet.ToArrayAsync();
            var data = Mapper.Map<List<OilsquareEntity>>(dbData);
            return data;
        }
    }
}