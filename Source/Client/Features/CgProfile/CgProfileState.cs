namespace MyBlazorApp.Features.Profiles
{
  using BlazorState;

  internal partial class CgProfileState : State<CgProfileState>
  {
    public string Level { get; set; }
    public string Rank { get; set; }
    public string Name { get; set; }
    public int Ex { get; set; }

    public override void Initialize() { }
  }
}
