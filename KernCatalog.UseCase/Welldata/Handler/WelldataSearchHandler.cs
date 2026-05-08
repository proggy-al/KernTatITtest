using Microsoft.Extensions.Localization;
using Tn.Sdk;
using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

[SdkDiAutoRegistration]
internal class WelldataSearchHandler : UcOperationHandler<WelldataSearch>
{
    private readonly IWelldataSearchRequest _request;

    public WelldataSearchHandler(
        IWelldataSearchRequest request,
        IStringLocalizer<WelldataSearch> localizer
    ) : base(localizer)
    {
        _request = request;
    }

    protected async override ValueTask<WelldataSearch> ExecuteAsync(WelldataSearch oper)
    {
        oper.DataOut = await _request.FindAsync(oper.DataIn);
        oper.DataSetInfo.Count = oper.DataOut.Count;
        return oper;
    }
}
