namespace MyBlazorApp.Features.Profiles
{
  using BlazorState;

  internal partial class CgProfileState : State<CgProfileState>
  {
    public ProfileDto _CgProfile;

    public ProfileDto CgProfile => _CgProfile;

    public CgProfileState()
    {
      _CgProfile = new ProfileDto();

    }
    public override void Initialize() { }
  }
}
