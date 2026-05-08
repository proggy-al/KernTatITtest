using Microsoft.Extensions.Localization;
using Tn.Sdk;
using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

[SdkDiAutoRegistration]
internal class OilsquareSearchHandler : UcOperationHandler<OilsquareSearch>
{
    private readonly IOilsquareSearchRequest _request;

    public OilsquareSearchHandler(
        IOilsquareSearchRequest request,
        IStringLocalizer<OilsquareSearch> localizer
    ) : base(localizer)
    {
        _request = request;
    }

    protected async override ValueTask<OilsquareSearch> ExecuteAsync(OilsquareSearch oper)
    {
        oper.DataOut = await _request.ExecuteAsync(oper.DataIn);
        oper.DataSetInfo.Count = oper.DataOut.Count;        
        return oper;
    }
}
