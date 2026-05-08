using Microsoft.Extensions.Localization;
using Tn.Sdk;
using Tn.Sdk.UseCase;

namespace KernCatalog.UseCase;

[SdkDiAutoRegistration]
internal class UbrSearchHandler : UcOperationHandler<UbrSearch>
{
    private readonly IUbrSearchRequest _request;

    public UbrSearchHandler(
        IUbrSearchRequest request,
        IStringLocalizer<UbrSearch> localizer
    ) : base(localizer)
    {
        _request = request;
    }

    protected override async ValueTask<UbrSearch> ExecuteAsync(UbrSearch oper)
    {
        oper.DataOut = await _request.ExecuteAsync(oper.DataIn);
        oper.DataSetInfo.Count = oper.DataOut.Count;
        return oper;
    }
}
