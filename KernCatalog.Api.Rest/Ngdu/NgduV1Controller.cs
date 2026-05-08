using Microsoft.AspNetCore.Mvc;
using Tn.Sdk.Api.Rest;
using Tn.Sdk.UseCase;
using Tn.Sdk;
using KernCatalog.UseCase;
using KernCatalog.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KernCatalog.Api.Rest;

/// <summary>
/// НГДУ. REST API.
/// </summary>
[SdkGenGenerateCrud<
    NgduCreateOne, NgduCreateMany,
    NgduReadOne, NgduReadMany,
    NgduUpdateOne, NgduUpdateMany,
    NgduDeleteOne, NgduDeleteMany
>(EntitySystemName = SystemName)]
[RestApiController("ngdu", "Ngdu", "НГДУ", 1)]
public partial class NgduV1Controller : RestApiController
{
    /// <summary>Системное имя.</summary>
    public const string SystemName = "ngdu";

    /// <summary>
    /// Получить список НГДУ.
    /// </summary>
    /// <param name="handler">Обработчик.</param>
    /// <returns>Список НГДУ.</returns>
    [RestApiGet("all")]
    public Task<RestApiResponse<IReadOnlyCollection<NgduEntity>>> ReadAll(
        [FromServices] IUcOperationHandler<NgduReadAll> handler
    ) =>
        handler.ExecuteAsync(new())
            .BuildRestApiResult<NgduReadAll, IReadOnlyCollection<NgduEntity>>();

    /// <summary>
    /// Найти.
    /// </summary>
    /// <param name="handler">Обработчик операции.</param>    
    /// <param name="dataIn">DataIn</param>
    /// <returns>Список НГДУ.</returns>
    /// <response code="200">Список НГДУ.</response>
    /// <response code="500">Ошибка.</response>
    [RestApiGet("search")]
    [RestApiActionMetadata(SystemName, EntityOperations.Read)]
    public Task<RestApiResponse<IReadOnlyCollection<NgduEntity>>> Search(
        [FromServices] IUcOperationHandler<NgduSearch> handler,
        [FromQuery()] NgduSearch.Filter dataIn
    ) =>
        handler
            .ExecuteAsync(new(dataIn))
            .BuildRestApiResult<NgduSearch, IReadOnlyCollection<NgduEntity>>();    
}
