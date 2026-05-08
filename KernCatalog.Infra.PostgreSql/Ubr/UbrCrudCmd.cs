using KernCatalog.UseCase;
using Tn.Sdk;
using Tn.Sdk.Dal;

namespace KernCatalog.Infra.PostgreSql;

// Автоматическое заполнение аудит полей.
[PostgreSqlWithAuditCommand<IKernCatalogDataContext, UbrDb>]
internal partial class UbrCrudCmd : IUbrCreateRequest, IUbrReadRequest, IUbrUpdateRequest, IUbrDeleteRequest
{
    private static ModelTable GetTableModel() => UbrDb.Model;
    private static partial string[] GetFields() =>
        ["ubrnaim", "ubrcomment", "act"];
}