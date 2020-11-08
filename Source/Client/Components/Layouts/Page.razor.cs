namespace MyBlazorApp.Components
{
  using Microsoft.AspNetCore.Components;
  using MyBlazorApp.Features.Bases;

  public partial class Page : BaseComponent
  {
    [Parameter] public RenderFragment HeaderContent { get; set; }
    [Parameter] public RenderFragment MainContent { get; set; }
    [Parameter] public bool ShowNavBar { get; set; } = true;
    [Parameter] public bool ShowFooter { get; set; } = true;

    private string Version => ApplicationState.Version;
  }
}
