//#WeatherForecast #Dto #Api
namespace MyBlazorApp.Features.Profiles
{
  using System;

  /// <summary>
  /// The weather forecast
  /// </summary>
  public class ProfileDto
  {
    public string Level { get; set; }
    public string Rank { get; set; }
    public string Name { get; set; }
    public int Ex { get; set; }
    public ProfileDto()
    {

    }
    public ProfileDto(string aLevel, string aRank, string aName, int aEx)
    {
        Level = aLevel;
        Name = aName;
        Ex = aEx;
        Rank = aRank;
    }

  }
}
