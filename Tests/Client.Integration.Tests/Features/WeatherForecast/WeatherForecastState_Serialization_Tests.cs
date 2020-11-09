namespace WeatherForecastDto
{
  using Shouldly;
  using System;
  using System.Text.Json;
  using MyBlazorApp.Features.WeatherForecasts;

  public class Should
  {
    public void SerializeAndDeserialize()
    {
      //Arrange
      var jsonSerializerOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
      var weatherForecastDto = new ProfileDto
      (
        aDate: DateTime.MinValue.ToUniversalTime(),
        aSummary: "Summary 1",
        aTemperatureC: 24
      );

      string json = JsonSerializer.Serialize(weatherForecastDto, jsonSerializerOptions);

      //Act
      ProfileDto parsed = JsonSerializer.Deserialize<ProfileDto>(json, jsonSerializerOptions);

      //Assert
      weatherForecastDto.TemperatureC.ShouldBe(parsed.TemperatureC);
      weatherForecastDto.Summary.ShouldBe(parsed.Summary);
      weatherForecastDto.Date.ShouldBe(parsed.Date);
    }
  }
}
