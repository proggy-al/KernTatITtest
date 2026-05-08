using Microsoft.Extensions.Localization;
using Tn.Sdk;
using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

[SdkDiAutoRegistration]
internal class OilfieldSearchHandler : UcOperationHandler<OilfieldSearch>
{
    private readonly IOilfieldSearchRequest _request;

    public OilfieldSearchHandler(
        IOilfieldSearchRequest request,
        IStringLocalizer<OilfieldSearch> localizer
    ) : base(localizer)
    {
        _request = request;
    }

    protected override async ValueTask<OilfieldSearch> ExecuteAsync(OilfieldSearch oper)
    {
        oper.DataOut = await _request.ExecuteAsync(oper.DataIn);
        oper.DataSetInfo.Count = oper.DataOut.Count;
        return oper;
    }
}
