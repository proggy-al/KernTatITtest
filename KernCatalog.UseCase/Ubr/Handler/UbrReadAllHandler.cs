using Microsoft.Extensions.Localization;
using Tn.Sdk.UseCase;
using Tn.Sdk;

namespace KernCatalog.UseCase;

[SdkDiAutoRegistration]
internal class UbrReadAllHandler : UcOperationHandler<UbrReadAll>
{
    private readonly IUbrReadAllRequest _request;

    public UbrReadAllHandler(
        IUbrReadAllRequest request,
        IStringLocalizer<UbrReadAll> localizer
    ) : base(localizer)
    {
        _request = request;
    }

    protected async override ValueTask<UbrReadAll> ExecuteAsync(UbrReadAll oper)
    {
        oper.DataOut = await _request.ExecuteAsync();
        oper.DataSetInfo.Count = oper.DataSetInfo.Count;
        return oper;
    }
}
