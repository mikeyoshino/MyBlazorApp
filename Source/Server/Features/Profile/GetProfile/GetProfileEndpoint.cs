namespace MyBlazorApp.Features.Profiles
{
  using Microsoft.AspNetCore.Mvc;
  using Swashbuckle.AspNetCore.Annotations;
  using System.Net;
  using System.Threading.Tasks;
  using MyBlazorApp.Features.Bases;

  public class GetProfileEndpoint : BaseEndpoint<GetProfileRequest, GetProfileResponse>
  {
    /// <summary>
    /// Your summary these comments will show in the Open API Docs
    /// </summary>
    /// <param name="aGetProfileRequest"><see cref="GetProfileRequest"/></param>
    /// <returns><see cref="GetProfileResponse"/></returns>
    [HttpGet(GetProfileRequest.RouteTemplate)]
    [SwaggerOperation(Tags = new[] { FeatureAnnotations.FeatureGroup })]
    [ProducesResponseType(typeof(GetProfileResponse), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> Process(GetProfileRequest aGetProfileRequest) => 
      await Send(aGetProfileRequest);
  }
}
