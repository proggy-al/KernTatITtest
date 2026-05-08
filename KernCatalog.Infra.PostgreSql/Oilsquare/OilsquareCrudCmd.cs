using Tn.Sdk;
using Tn.Sdk.Dal;

namespace KernCatalog.Infra.PostgreSql;

using UseCase;

// Автоматическое заполнение аудит полей.
[PostgreSqlWithAuditCommand<IKernCatalogDataContext, OilsquareDb>]
internal partial class OilsquareCrudCmd : IOilsquareCreateRequest, IOilsquareReadRequest, IOilsquareUpdateRequest, IOilsquareDeleteRequest
{
    private static ModelTable GetTableModel() => OilsquareDb.Model;
    private static partial string[] GetFields() =>
        ["oilsquarenaim", "oilsquarecomment", "oilfield_uid"];
}