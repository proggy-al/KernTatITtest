using Microsoft.Extensions.Localization;
using Tn.Sdk;
using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

[SdkDiAutoRegistration]
internal class OilsquareReadAllHandler : UcOperationHandler<OilsquareReadAll>
{
    private readonly IOilsquareReadAllRequest _request;

    public OilsquareReadAllHandler(
        IOilsquareReadAllRequest request,
        IStringLocalizer<OilsquareReadAll> localizer
    ) : base(localizer)
    {
        _request = request;
    }

    protected async override ValueTask<OilsquareReadAll> ExecuteAsync(OilsquareReadAll oper)
    {
        oper.DataOut = await _request.ExecuteAsync();
        oper.DataSetInfo.Count = oper.DataSetInfo.Count;
        return oper;
    }
}
