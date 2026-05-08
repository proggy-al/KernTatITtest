using KernCatalog.UseCase;
using Tn.Sdk;
using Tn.Sdk.Dal;

namespace KernCatalog.Infra.PostgreSql;

// Автоматическое заполнение аудит полей.
[PostgreSqlWithAuditCommand<IKernCatalogDataContext, WelldataDb>]
internal partial class WelldataCrudCmd : IWelldataCreateRequest, IWelldataReadRequest, IWelldataUpdateRequest, IWelldataDeleteRequest
{
    private static ModelTable GetTableModel() => WelldataDb.Model;
    private static partial string[] GetFields() =>
        ["wellnum", "wellcategory", "svn", "wellx", "welly", "wella", "oilsquare_uid", "ngdu_uid", "ubr_uid"];
}