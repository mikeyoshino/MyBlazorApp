namespace MyBlazorApp.Features.WeatherForecasts
{
  using BlazorState;
  using System.Collections.Generic;

  internal partial class WeatherForecastsState : State<WeatherForecastsState>
  {
    private List<ProfileDto> _WeatherForecasts;

    public IReadOnlyList<ProfileDto> WeatherForecasts => _WeatherForecasts.AsReadOnly();

    public WeatherForecastsState()
    {
      _WeatherForecasts = new List<ProfileDto>();
    }

    public override void Initialize() { }
  }
}
