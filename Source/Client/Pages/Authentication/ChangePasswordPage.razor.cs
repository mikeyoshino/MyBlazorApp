namespace MyBlazorApp.Pages
{
  using MyBlazorApp.Features.Bases;

  public partial class ChangePasswordPage : BaseComponent
  {
    private const string RouteTemplate = "/changePassword";

    public static string GetRoute() => RouteTemplate;
  }
}
