using KernCatalog.Core;
using KernCatalog.UseCase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Tn.Sdk.Dal.EfCore;

namespace KernCatalog.Infra.PostgreSql
{
    internal class WelldataReadAllCmd(
    IKernCatalogDataContext dc, IStringLocalizer<IWelldataReadAllRequest> localizer
) :
    EfCoreBaseCommandWithMapper<WelldataDb>(dc.EfProvider, localizer, dc.Mapper),
    IWelldataReadAllRequest
    {
        public async ValueTask<IReadOnlyCollection<WelldataEntity>> ExecuteAsync()
        {
            var dbData = await DbSet.ToArrayAsync();
            var data = Mapper.Map<List<WelldataEntity>>(dbData);
            return data;
        }
    }
}
