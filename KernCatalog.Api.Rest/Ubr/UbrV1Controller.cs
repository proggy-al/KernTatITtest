using Microsoft.AspNetCore.Mvc;
using Tn.Sdk;
using Tn.Sdk.Api.Rest;
using Tn.Sdk.UseCase;

namespace KernCatalog.Api.Rest;

using Core;
using UseCase;

/// <summary>
/// УБР. REST API.
/// </summary>
[SdkGenGenerateCrud<
    UbrCreateOne, UbrCreateMany,
    UbrReadOne, UbrReadMany,
    UbrUpdateOne, UbrUpdateMany,
    UbrDeleteOne, UbrDeleteMany
>(EntitySystemName = SystemName)]
[RestApiController("ubr", "Ubr", "УБР", 1)]
public partial class UbrV1Controller : RestApiController
{
    /// <summary>Системное имя.</summary>
    public const string SystemName = "ubr";

    /// <summary>
    /// Получить список УБР.
    /// </summary>
    /// <param name="handler">Обработчик.</param>
    /// <returns>Список УБР.</returns>
    [RestApiGet("all")]
    public Task<RestApiResponse<IReadOnlyCollection<UbrEntity>>> ReadAll(
        [FromServices] IUcOperationHandler<UbrReadAll> handler
    ) =>
        handler.ExecuteAsync(new())
            .BuildRestApiResult<UbrReadAll, IReadOnlyCollection<UbrEntity>>();


    /// <summary>
    /// Найти.
    /// </summary>
    /// <param name="handler">Обработчик операции.</param>
    /// <param name="dataIn">DataIn</param>
    /// <returns>Список УБР.</returns>
    /// <response code="200">Список УБР.</response>
    /// <response code="500">Ошибка.</response>
    [RestApiGet("search")]
    [RestApiActionMetadata(SystemName, EntityOperations.Read)]
    public Task<RestApiResponse<IReadOnlyCollection<UbrEntity>>> Search(
        [FromServices] IUcOperationHandler<UbrSearch> handler,
        [FromQuery()] UbrSearch.Filter dataIn
    ) =>
        handler
            .ExecuteAsync(new(dataIn))
            .BuildRestApiResult<UbrSearch, IReadOnlyCollection<UbrEntity>>();
}
