using Microsoft.Extensions.Localization;
using Tn.Sdk;
using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

[SdkDiAutoRegistration]
internal class NgduReadAllHandler : UcOperationHandler<NgduReadAll>
{
    private readonly INgduReadAllRequest _request;

    public NgduReadAllHandler(
        INgduReadAllRequest request,
        IStringLocalizer<NgduReadAll> localizer
    ) : base(localizer)
    {
        _request = request;
    }

    protected async override ValueTask<NgduReadAll> ExecuteAsync(NgduReadAll oper)
    {
        oper.DataOut = await _request.ExecuteAsync();
        oper.DataSetInfo.Count = oper.DataSetInfo.Count;
        return oper;
    }
}
