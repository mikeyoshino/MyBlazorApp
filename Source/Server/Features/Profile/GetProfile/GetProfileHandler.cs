namespace MyBlazorApp.Features.Profiles
{
  using MediatR;
  using Newtonsoft.Json;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;
  
  public class GetProfileHandler : IRequestHandler<GetProfileRequest, GetProfileResponse>
  {
    private readonly HttpClient HttpClient;
    private string CgUrl = "https://www.codingame.com/services/CodinGamer/findCodingamePointsStatsByHandle";
    private string CgId = "ede69031e8671a592c04562a69d92a250402493";
    public GetProfileHandler(HttpClient aHttpClient)
    {
      HttpClient = aHttpClient;
    }

    public async Task<GetProfileResponse> Handle
    (
      GetProfileRequest aGetProfileRequest,
      CancellationToken aCancellationToken
    )
    {
      var content = new StringContent(CgId);
      HttpResponseMessage getPorfileResponse = await HttpClient.PostAsync(CgUrl, content);
      string resultString = await getPorfileResponse.Content.ReadAsStringAsync();
      GetProfileResponse profileResult = JsonConvert.DeserializeObject<GetProfileResponse>(resultString);

      var response = new GetProfileResponse(aGetProfileRequest.CorrelationId)
      {
        Level = "555", 
        Rank = "555"
      };
      return await Task.FromResult(response);
    }
  }
}
