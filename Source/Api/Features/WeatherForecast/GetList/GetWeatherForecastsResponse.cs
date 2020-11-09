//#WeatherForecast #GetWeatherForecasts #Response #Api
namespace MyBlazorApp.Features.WeatherForecasts
{
  using System;
  using System.Collections.Generic;
  using MyBlazorApp.Features.Bases;

  public class GetWeatherForecastsResponse : BaseResponse
  {
    /// <summary>
    /// The collection of forecasts requested
    /// </summary>
    public List<ProfileDto> WeatherForecasts { get; set; }

    /// <summary>
    /// a default constructor is required for client side deserialization
    /// </summary>
    public GetWeatherForecastsResponse()
    {
      WeatherForecasts = new List<ProfileDto>();
    }

    public GetWeatherForecastsResponse(Guid aCorrelationId) : base(aCorrelationId)
    {
      WeatherForecasts = new List<ProfileDto>();
    }

  }
}
