namespace MyBlazorApp.Features.Bases
{
  using BlazorState;
  using MyBlazorApp.Features.Applications;
  using MyBlazorApp.Features.Counters;
  using MyBlazorApp.Features.EventStreams;
  using MyBlazorApp.Features.Profiles;
  using MyBlazorApp.Features.WeatherForecasts;

  /// <summary>
  /// Base Handler that makes it easy to access state
  /// </summary>
  /// <typeparam name="TAction"></typeparam>
  internal abstract class BaseHandler<TAction> : ActionHandler<TAction>
    where TAction : IAction
  {
    protected ApplicationState ApplicationState => Store.GetState<ApplicationState>();

    protected CounterState CounterState => Store.GetState<CounterState>();

    protected EventStreamState EventStreamState => Store.GetState<EventStreamState>();

    protected WeatherForecastsState WeatherForecastsState => Store.GetState<WeatherForecastsState>();
    protected CgProfileState CgProfileState => Store.GetState<CgProfileState>();

    public BaseHandler(IStore aStore) : base(aStore) { }
  }
}
