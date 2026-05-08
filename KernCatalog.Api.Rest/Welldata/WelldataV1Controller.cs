using Microsoft.AspNetCore.Mvc;
using Tn.Sdk;
using Tn.Sdk.Api.Rest;
using Tn.Sdk.UseCase;

namespace KernCatalog.Api.Rest;

using Core;
using UseCase;

/// <summary>
/// Скважина. REST API.
/// </summary>
[SdkGenGenerateCrud<
    WelldataCreateOne, WelldataCreateMany,
    WelldataReadOne, WelldataReadMany,
    WelldataUpdateOne, WelldataUpdateMany,
    WelldataDeleteOne, WelldataDeleteMany
>(EntitySystemName = SystemName)]
[RestApiController("welldata", "Welldata", "Скважина", 1)]
public partial class WelldataV1Controller : RestApiController
{
    /// <summary>Системное имя.</summary>
    public const string SystemName = "welldata";

    /// <summary>
    /// Получить список скважин.
    /// </summary>
    /// <param name="handler">Обработчик.</param>
    /// <returns>Список скважин.</returns>
    [RestApiGet("all")]
    public Task<RestApiResponse<IReadOnlyCollection<WelldataEntity>>> ReadAll(
        [FromServices] IUcOperationHandler<WelldataReadAll> handler
    ) =>
        handler.ExecuteAsync(new())
            .BuildRestApiResult<WelldataReadAll, IReadOnlyCollection<WelldataEntity>>();

    /// <summary>
    /// Найти.
    /// </summary>
    /// <param name="handler">Обработчик операции.</param>
    /// <param name="dateIn">DataIn</param>
    /// <returns>Список скважин.</returns>
    /// <response code="200">Список скважин.</response>
    /// <response code="500">Ошибка.</response>
    [RestApiGet("search")]
    [RestApiActionMetadata(SystemName, EntityOperations.Read)]
    public Task<RestApiResponse<IReadOnlyCollection<WelldataEntity>>> Search(
        [FromServices] IUcOperationHandler<WelldataSearch> handler,
        [FromQuery()] WelldataSearch.Filter dateIn        
    ) => handler
            .ExecuteAsync(new(dateIn))
            .BuildRestApiResult<WelldataSearch, IReadOnlyCollection<WelldataEntity>>();
}
