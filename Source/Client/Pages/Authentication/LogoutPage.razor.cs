namespace MyBlazorApp.Pages
{
  using MyBlazorApp.Features.Bases;

  public partial class LogoutPage : BaseComponent
  {
    private const string RouteTemplate = "/Logout";

    public static string GetRoute() => RouteTemplate;

  }
}
