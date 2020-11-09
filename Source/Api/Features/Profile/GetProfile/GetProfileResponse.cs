namespace MyBlazorApp.Features.Profiles
{
  using System;
  using System.Collections.Generic;
  using MyBlazorApp.Features.Bases;

  public class GetProfileResponse : BaseResponse
  {

    public string Level { get; set; }
    public string Rank { get; set; }
    public string Name { get; set; }
    public int Experience{ get; set; }
    public GetProfileResponse() { }

    public GetProfileResponse(Guid aCorrelationId) : base(aCorrelationId) { }
  }
}
