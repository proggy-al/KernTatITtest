using Microsoft.Extensions.Localization;
using Tn.Sdk;
using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

[SdkDiAutoRegistration]
internal class OilfieldReadAllHandler : UcOperationHandler<OilfieldReadAll>
{
    private readonly IOilfieldReadAllRequest _request;

    public OilfieldReadAllHandler(
        IOilfieldReadAllRequest request,
        IStringLocalizer<OilfieldReadAll> localizer
    ) : base(localizer)
    {
        _request = request;
    }

    protected async override ValueTask<OilfieldReadAll> ExecuteAsync(OilfieldReadAll oper)
    {
        oper.DataOut = await _request.ExecuteAsync();
        oper.DataSetInfo.Count = oper.DataSetInfo.Count;
        return oper;
    }
}
