using KernCatalog.Core;
using KernCatalog.UseCase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Tn.Sdk.Dal.EfCore;

namespace KernCatalog.Infra.PostgreSql
{
    internal class UbrReadAllCmd(
    IKernCatalogDataContext dc, IStringLocalizer<IUbrReadAllRequest> localizer
) :
    EfCoreBaseCommandWithMapper<UbrDb>(dc.EfProvider, localizer, dc.Mapper),
    IUbrReadAllRequest
    {
        public async ValueTask<IReadOnlyCollection<UbrEntity>> ExecuteAsync()
        {
            var dbData = await DbSet.ToArrayAsync();
            var data = Mapper.Map<List<UbrEntity>>(dbData);
            return data;
        }
    }
}
