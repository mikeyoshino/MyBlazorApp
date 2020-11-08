namespace MyBlazorApp.Pages
{
  using BlazorState.Features.Routing;
  using System.Threading.Tasks;
  using MyBlazorApp.Features.Bases;
  using static MyBlazorApp.Features.Applications.ApplicationState;

  public partial class CounterPage : BaseComponent
  {
    private const string RouteTemplate = "/Counter";

    public static string GetRoute() => RouteTemplate;

    private async Task ButtonClick() =>
      await Send(new RouteState.ChangeRouteAction { NewRoute = "/" }).ConfigureAwait(false);

    private async Task ResetButtonClick() => await Send(new ResetStoreAction()).ConfigureAwait(false);
  }
}
