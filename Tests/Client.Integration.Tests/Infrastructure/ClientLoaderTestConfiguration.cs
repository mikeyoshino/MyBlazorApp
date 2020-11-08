namespace MyBlazorApp.Client.Integration.Tests.Infrastructure
{
  using System;
  using MyBlazorApp.Features.ClientLoaders;

  [NotTest]
  public class ClientLoaderTestConfiguration : IClientLoaderConfiguration
  {
    public TimeSpan DelayTimeSpan => TimeSpan.FromMilliseconds(10);
  }
}
