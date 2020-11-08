namespace MyBlazorApp.Features.Profiles
{
  using System;
  using System.Collections.Generic;
  using MyBlazorApp.Features.Bases;

  public class GetProfileResponse : BaseResponse
  {
    public GetProfileResponse() { }

    public string Level { get; set; }
    public string Rank { get; set; }

    public GetProfileResponse(Guid aCorrelationId) : base(aCorrelationId) { }
  }
}
