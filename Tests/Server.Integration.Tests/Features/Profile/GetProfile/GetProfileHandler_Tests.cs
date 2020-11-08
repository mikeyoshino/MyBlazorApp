namespace GetProfileHandler
{
  using System.Threading.Tasks;
  using System.Text.Json;
  using Microsoft.AspNetCore.Mvc.Testing;
  using MyBlazorApp.Server.Integration.Tests.Infrastructure;
  using MyBlazorApp.Features.Profiles;
  using MyBlazorApp.Server;
  using FluentAssertions;

  public class Handle_Returns : BaseTest
  {
    private readonly GetProfileRequest GetProfileRequest;

    public Handle_Returns
    (
      WebApplicationFactory<Startup> aWebApplicationFactory,
      JsonSerializerOptions aJsonSerializerOptions
    ) : base(aWebApplicationFactory, aJsonSerializerOptions)
    {
      GetProfileRequest = new GetProfileRequest { ProfileId = "sample" };
    }

    public async Task GetProfileResponse()
    {
      GetProfileResponse GetProfileResponse = await Send(GetProfileRequest);

      ValidateGetProfileResponse(GetProfileResponse);
    }

    private void ValidateGetProfileResponse(GetProfileResponse aGetProfileResponse)
    {
      aGetProfileResponse.CorrelationId.Should().Be(GetProfileRequest.CorrelationId);
      ;// #TODO: check Other properties here
    }

  }
}
