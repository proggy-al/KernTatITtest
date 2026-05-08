using KernCatalog.Core;
using KernCatalog.UseCase;
using Microsoft.AspNetCore.Mvc;
using Tn.Sdk;
using Tn.Sdk.Api.Rest;
using Tn.Sdk.UseCase;

namespace KernCatalog.Api.Rest;

/// <summary>
/// Площадь. REST API.
/// </summary>
[SdkGenGenerateCrud<
    OilsquareCreateOne, OilsquareCreateMany,
    OilsquareReadOne, OilsquareReadMany,
    OilsquareUpdateOne, OilsquareUpdateMany,
    OilsquareDeleteOne, OilsquareDeleteMany
>(EntitySystemName = SystemName)]
[RestApiController("oilsquare", "Oilsquare", "Площадь", 1)]
public partial class OilsquareV1Controller : RestApiController
{
    /// <summary>Системное имя.</summary>
    public const string SystemName = "oilsquare";

    /// <summary>
    /// Получить список площадей.
    /// </summary>
    /// <param name="handler">Обработчик.</param>
    /// <returns>Список площадей.</returns>
    [RestApiGet("all")]
    public Task<RestApiResponse<IReadOnlyCollection<OilsquareEntity>>> ReadAll(
        [FromServices] IUcOperationHandler<OilsquareReadAll> handler
    ) =>
        handler.ExecuteAsync(new())
            .BuildRestApiResult<OilsquareReadAll, IReadOnlyCollection<OilsquareEntity>>();


    /// <summary>
    /// Найти.
    /// </summary>
    /// <param name="handler">Обработчик операции.</param>
    /// <param name="dataIn">DataIn</param>
    /// <returns>Список авторов.</returns>
    /// <response code="200">Список площадей.</response>
    /// <response code="500">Ошибка.</response>
    [RestApiGet("search")]
    [RestApiActionMetadata(SystemName, EntityOperations.Read)]
    public Task<RestApiResponse<IReadOnlyCollection<OilsquareEntity>>> Search(
        [FromServices] IUcOperationHandler<OilsquareSearch> handler,
        [FromQuery()] OilsquareSearch.Filter dataIn
    ) =>
        handler
            .ExecuteAsync(new(dataIn))
            .BuildRestApiResult<OilsquareSearch, IReadOnlyCollection<OilsquareEntity>>();
}
