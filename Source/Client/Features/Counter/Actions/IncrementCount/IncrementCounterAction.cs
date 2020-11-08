namespace MyBlazorApp.Features.Counters
{
  using MyBlazorApp.Features.Bases;

  internal partial class CounterState
  {
    public class IncrementCounterAction : BaseAction
    {
      public int Amount { get; set; }
    }
  }
}
