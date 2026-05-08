using Microsoft.AspNetCore.Mvc;
using Tn.Sdk;
using Tn.Sdk.Api.Rest;
using Tn.Sdk.UseCase;

namespace KernCatalog.Api.Rest;

using KernCatalog.Core;
using KernCatalog.UseCase;

/// <summary>
/// Месторождение. REST API.
/// </summary>
[SdkGenGenerateCrud<
    OilfieldCreateOne, OilfieldCreateMany,
    OilfieldReadOne, OilfieldReadMany,
    OilfieldUpdateOne, OilfieldUpdateMany,
    OilfieldDeleteOne, OilfieldDeleteMany
>(EntitySystemName = SystemName)]
[RestApiController("oilfield", "Oilfield", "Месторождение", 1)]
public partial class OilfieldV1Controller : RestApiController
{
    /// <summary>Системное имя.</summary>
    public const string SystemName = "oilfield";

    /// <summary>
    /// Получить список месторождений.
    /// </summary>
    /// <param name="handler">Обработчик.</param>
    /// <returns>Список месторождений.</returns>
    [RestApiGet("all")]
    public Task<RestApiResponse<IReadOnlyCollection<OilfieldEntity>>> ReadAll(
        [FromServices] IUcOperationHandler<OilfieldReadAll> handler
    ) =>
        handler.ExecuteAsync(new())
            .BuildRestApiResult<OilfieldReadAll, IReadOnlyCollection<OilfieldEntity>>();

    /// <summary>
    /// Найти.
    /// </summary>
    /// <param name="handler">Обработчик операции.</param>   
    /// <param name="dataIn">DataIn</param>
    /// <returns>Список месторождений.</returns>
    /// <response code="200">Список месторождений.</response>
    /// <response code="500">Ошибка.</response>
    [RestApiGet("search")]
    [RestApiActionMetadata(SystemName, EntityOperations.Read)]
    public Task<RestApiResponse<IReadOnlyCollection<OilfieldEntity>>> Search(
        [FromServices] IUcOperationHandler<OilfieldSearch> handler,
        [FromQuery()] OilfieldSearch.Filter dataIn
    ) =>
        handler
            .ExecuteAsync(new(dataIn))
            .BuildRestApiResult<OilfieldSearch, IReadOnlyCollection<OilfieldEntity>>();
}
