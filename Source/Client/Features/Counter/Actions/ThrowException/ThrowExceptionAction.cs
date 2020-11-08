namespace MyBlazorApp.Features.Counters
{
  using MyBlazorApp.Features.Bases;

  internal partial class CounterState
  {
    public class ThrowExceptionAction : BaseAction
    {
      public string Message { get; set; }
    }
  }
}
