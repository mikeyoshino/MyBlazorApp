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
    public int Ex { get; set; }
    public ProfileDto CgProfile { get; set; }
    public GetProfileResponse()
    {
      CgProfile = new ProfileDto();
    }

    public GetProfileResponse(Guid aCorrelationId) : base(aCorrelationId) {

      CgProfile = new ProfileDto();

    }
  }
}
