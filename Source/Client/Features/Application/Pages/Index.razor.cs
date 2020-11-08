namespace MyBlazorApp.Pages
{
  using MyBlazorApp.Features.Bases;

  public partial class Index : BaseComponent
  {
    private const string RouteTemplate = "/";

    public static string GetRoute() => RouteTemplate;
  }
}
