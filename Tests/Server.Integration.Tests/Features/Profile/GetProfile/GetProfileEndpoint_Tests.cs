namespace GetProfileEndpoint
{
  using FluentAssertions;
  using Microsoft.AspNetCore.Mvc.Testing;
  using System.Net;
  using System.Net.Http;
  using System.Text.Json;
  using System.Threading.Tasks;
  using MyBlazorApp.Features.Profiles;
  using MyBlazorApp.Server.Integration.Tests.Infrastructure;
  using MyBlazorApp.Server;

  public class Returns : BaseTest
  {
    private readonly GetProfileRequest GetProfileRequest;

    public Returns
    (
      WebApplicationFactory<Startup> aWebApplicationFactory,
      JsonSerializerOptions aJsonSerializerOptions
    ) : base(aWebApplicationFactory, aJsonSerializerOptions)
    {
      GetProfileRequest = new GetProfileRequest { ProfileId = "sample" };
    }

    public async Task GetProfileResponse()
    {
      GetProfileResponse GetProfileResponse =
        await GetJsonAsync<GetProfileResponse>(GetProfileRequest.GetRoute());

      ValidateGetProfileResponse(GetProfileResponse);
    }

    public async Task ValidationError()
    {
      // Set invalid value
      GetProfileRequest.ProfileId = string.Empty;

      HttpResponseMessage httpResponseMessage = await HttpClient.GetAsync(GetProfileRequest.GetRoute());

      string json = await httpResponseMessage.Content.ReadAsStringAsync();

      httpResponseMessage.StatusCode.Should().Be(HttpStatusCode.BadRequest);
      json.Should().Contain("errors");
      json.Should().Contain(nameof(GetProfileRequest.ProfileId));
    }

    private void ValidateGetProfileResponse(GetProfileResponse aGetProfileResponse)
    {
      aGetProfileResponse.CorrelationId.Should().Be(GetProfileRequest.CorrelationId);
      // check Other properties here
    }
  }
}
