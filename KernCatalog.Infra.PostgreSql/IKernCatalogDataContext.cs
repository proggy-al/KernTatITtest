using Tn.Sdk.Dal.EfCore;
using Tn.Sdk.Dal;
using Tn.Sdk;

namespace KernCatalog.Infra.PostgreSql
{
    /// <summary>
    /// Контекст данных для "Каталог керна".
    /// </summary>
    public interface IKernCatalogDataContext :
    IDataContextAdoConnectionAdapter,
    IDataContextSqlAdapter,
    IDataContextEfAdapter,
    IDataContextTransactionAdapter,
    IMapperFactory
    {
    }
}
