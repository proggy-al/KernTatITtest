using Microsoft.Extensions.Localization;
using Tn.Sdk;
using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

[SdkDiAutoRegistration]
internal class NgduSearchHandler : UcOperationHandler<NgduSearch>
{
    private readonly INgduSearchRequest _request;

    public NgduSearchHandler(
        INgduSearchRequest request,
        IStringLocalizer<NgduSearch> localizer
    ) : base(localizer)
    {
        _request = request;
    }

    protected async override ValueTask<NgduSearch> ExecuteAsync(NgduSearch oper)
    {
        oper.DataOut = await _request.ExecuteAsync(oper.DataIn);
        oper.DataSetInfo.Count = oper.DataOut.Count;
        return oper;
    }
}
