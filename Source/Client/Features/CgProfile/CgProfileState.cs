namespace MyBlazorApp.Features.Profiles
{
  using BlazorState;

  internal partial class CgProfileState : State<CgProfileState>
  {
    private ProfileDto _ProfileDto;

    public ProfileDto Profile => _ProfileDto;

    public CgProfileState()
    {
      _ProfileDto = new ProfileDto();

    }

    public override void Initialize()
    {
    }
  }
}
