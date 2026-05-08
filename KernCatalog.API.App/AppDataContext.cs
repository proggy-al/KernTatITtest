using KernCatalog.Infra.PostgreSql;
using MapsterMapper;

using Tn.Sdk;
using Tn.Sdk.Dal;
using Tn.Sdk.Dal.EfCore;
using Tn.Sdk.Dal.PostgreSql;


namespace KernCatalog.Api.App;

/// <summary>
/// Контекст данных для НСИ "Организационная структура".
/// </summary>
public class AppDataContext : DataContext, IKernCatalogDataContext
{
    readonly PostgreSqlConnectionProvider _connectionProvider;
    readonly PostgreSqlAdoProvider _adoProvider;
    readonly IEfProvider _efProvider;
    readonly IMapper _mapper;

    /// <summary>
    /// Создать <see cref="AppDataContext"/>
    /// </summary>
    /// <param name="serviceProvider">Поставщик сервисов DI.</param>
    /// <param name="options">Опции.</param>
    public AppDataContext(
        IServiceProvider serviceProvider, 
        DataContextOptions<AppDataContext> options)
        : base(serviceProvider, options)
    {
        _connectionProvider = new PostgreSqlConnectionProvider(this);
        _adoProvider = _connectionProvider.BuildAdoProvider(this);
        _efProvider = _connectionProvider.BuildEfProvider(this);
        _mapper = this.BuildMapper();
    }

    /// <inheritdoc/>
    public IAdoConnectionProvider ConnectionProvider => _connectionProvider;
    /// <inheritdoc/>
    public ISqlBroker SqlBroker => _adoProvider;
    /// <inheritdoc/>
    public IEfProvider EfProvider => _efProvider;
    /// <inheritdoc/>
    public ITransactionFactory TransactionFactory => _connectionProvider;
    /// <inheritdoc/>
    public IMapper Mapper => _mapper;
}
