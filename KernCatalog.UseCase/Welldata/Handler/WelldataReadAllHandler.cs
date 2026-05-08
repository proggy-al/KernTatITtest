using Microsoft.Extensions.Localization;
using Tn.Sdk;
using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

[SdkDiAutoRegistration]
internal class WelldataReadAllHandler : UcOperationHandler<WelldataReadAll>
{
    private readonly IWelldataReadAllRequest _request;

    public WelldataReadAllHandler(
        IWelldataReadAllRequest request,
        IStringLocalizer<WelldataReadAll> localizer
    ) : base(localizer)
    {
        _request = request;
    }

    protected async override ValueTask<WelldataReadAll> ExecuteAsync(WelldataReadAll oper)
    {
        oper.DataOut = await _request.ExecuteAsync();
        oper.DataSetInfo.Count = oper.DataSetInfo.Count;
        return oper;
    }
}
