using KernCatalog.UseCase;
using Tn.Sdk;
using Tn.Sdk.Dal;

namespace KernCatalog.Infra.PostgreSql;

// Автоматическое заполнение аудит полей.
[PostgreSqlWithAuditCommand<IKernCatalogDataContext, OilfieldDb>]
internal partial class OilfieldCrudCmd : IOilfieldCreateRequest, IOilfieldReadRequest, IOilfieldUpdateRequest, 
    IOilfieldDeleteRequest
{
    private static ModelTable GetTableModel() => OilfieldDb.Model;
    private static partial string[] GetFields() =>
        ["oilfieldnaim", "oilfieldcomment"];
}