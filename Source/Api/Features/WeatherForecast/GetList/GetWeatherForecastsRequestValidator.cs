//#WeatherForecast #GetWeatherForecasts #Validator #Api
namespace MyBlazorApp.Features.WeatherForecasts
{
  using FluentValidation;

  public class GetWeatherForecastsRequestValidator : AbstractValidator<GetWeatherForecastsRequest>
  {

    public GetWeatherForecastsRequestValidator()
    {
      RuleFor(aGetWeatherForecastRequest => aGetWeatherForecastRequest.Days)
        .NotEmpty().GreaterThan(0);
    }
  }
}
