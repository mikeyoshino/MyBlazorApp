namespace MyBlazorApp.Features.EventStreams
{
  using MyBlazorApp.Features.Bases;

  internal partial class EventStreamState
  {
    public class AddEventAction : BaseAction
    {
      public string Message { get; set; }
    }
  }
}
