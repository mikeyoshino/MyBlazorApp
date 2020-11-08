namespace MyBlazorApp.Features.Profiles
{
  using MediatR;
  using MyBlazorApp.Features.Bases;

  public class GetProfileRequest : BaseApiRequest, IRequest<GetProfileResponse>
  {
    public const string RouteTemplate = "api/Profiles/GetProfile";

    /// <summary>
    /// Set Properties and Update Docs
    /// </summary>
    /// <example>TODO</example>
    public string ProfileId { get; set; }

    internal override string GetRoute() => $"{RouteTemplate}?{nameof(ProfileId)}={ProfileId}&{nameof(CorrelationId)}={CorrelationId}";
  }
}
