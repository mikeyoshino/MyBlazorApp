namespace MyBlazorApp.Features.Profiles
{
  using BlazorState;
  using MediatR;
  using System.Net.Http;
  using System.Net.Http.Json;
  using System.Threading;
  using System.Threading.Tasks;
  using MyBlazorApp.Features.Bases;

  internal partial class CgProfileState
  {
    public class FetchCgProfileHandler : BaseHandler<FetchCgProfileAction>
    {
      private readonly HttpClient HttpClient;

      public FetchCgProfileHandler(IStore aStore, HttpClient aHttpClient) : base(aStore)
      {
        HttpClient = aHttpClient;
      }
      public override async Task<Unit> Handle(FetchCgProfileAction aFetchCgProfileAction, CancellationToken aCancellationToken)
      {
        var getGetProfileRequest = new GetProfileRequest { ProfileId = "TODO" };
        GetProfileResponse getProfileResponse =
          await HttpClient.GetFromJsonAsync<GetProfileResponse>
          (
            getGetProfileRequest.GetRoute(), aCancellationToken
          )
          .ConfigureAwait(false);
        CgProfileState._CgProfile = getProfileResponse.CgProfile;
        return Unit.Value;

      }
    }
  }
}
