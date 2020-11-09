namespace MyBlazorApp.Features.Profiles
{
  using MediatR;
  using Newtonsoft.Json;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Net.Http;
  using System.Text;
  using System.Threading;
  using System.Threading.Tasks;
  
  public class GetProfileHandler : IRequestHandler<GetProfileRequest, GetProfileResponse>
  {
    private readonly HttpClient HttpClient;
    private readonly string CgUrl = "https://www.codingame.com/services/CodinGamer/findCodingamePointsStatsByHandle/";
    private readonly string CgId = "[ede69031e8671a592c04562a69d92a250402493]";
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
      var content = new StringContent(CgId, Encoding.UTF8, "application/json");
      HttpResponseMessage getPorfileResponse = await HttpClient.PostAsync(CgUrl, content);
      string resultString = await getPorfileResponse.Content.ReadAsStringAsync();
      CgProfile CgObj = JsonConvert.DeserializeObject<CgProfile>(resultString);
      var response = new GetProfileResponse(aGetProfileRequest.CorrelationId)

      {
        Level = CgObj.Codingamer.level,
        Rank = CgObj.Codingamer.rank,
        Experience = CgObj.Codingamer.xp,
        Name = CgObj.Codingamer.pseudo
      };
      return await Task.FromResult(response);
    }
  }
  public class Codingamer
  {
    public int userId { get; set; }
    public string countryId { get; set; }
    public string pseudo { get; set; }
    public int xp { get; set; }
    public string rank { get; set; }
    public string level { get; set; }
  }
  public class CgProfile
  {
    public Codingamer Codingamer { get; set; }
  }
}
