namespace MyBlazorApp.Pages
{
  using System.Threading.Tasks;
  using MyBlazorApp.Features.Bases;
  using static MyBlazorApp.Features.Profiles.CgProfileState;
  public partial class CgProfilePage : BaseComponent
  {
    private const string RouteTemplate = "/CgProfile";

    public static string GetRoute() => RouteTemplate;

    protected override async Task OnInitializedAsync() =>
      await Send(new FetchCgProfileAction()).ConfigureAwait(false);
  }
}
