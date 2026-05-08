using KernCatalog.UseCase;
using Tn.Sdk;
using Tn.Sdk.Dal;

namespace KernCatalog.Infra.PostgreSql;

// Автоматическое заполнение аудит полей.
[PostgreSqlWithAuditCommand<IKernCatalogDataContext, NgduDb>]
internal partial class NgduCrudCmd : 
    INgduCreateRequest, INgduReadRequest, INgduUpdateRequest, INgduDeleteRequest
{
    private static ModelTable GetTableModel() => NgduDb.Model;
    private static partial string[] GetFields() =>
        ["ngdunaim", "ngducomment", "act"];
}