namespace MyBlazorApp.EndToEnd.Tests.Infrastructure
{
  using System;
  using MyBlazorApp.Features.ClientLoaders;

  public class TestClientLoaderConfiguration : IClientLoaderConfiguration
  {
    public TimeSpan DelayTimeSpan => TimeSpan.FromMilliseconds(10);
  }
}
