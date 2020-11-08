namespace MyBlazorApp.Features.Counters.Components
{
  using System.Threading.Tasks;
  using MyBlazorApp.Components;
  using MyBlazorApp.Features.Bases;
  using static MyBlazorApp.Features.Counters.CounterState;

  public partial class Counter : BaseComponent, IAttributeComponent
  {
    protected async Task ButtonClick() => await Send(new IncrementCounterAction { Amount = 5 }).ConfigureAwait(false);
  }
}
