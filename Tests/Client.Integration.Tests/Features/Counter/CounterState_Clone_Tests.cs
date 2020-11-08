namespace CounterState
{
  using AnyClone;
  using Shouldly;
  using MyBlazorApp.Client.Integration.Tests.Infrastructure;
  using MyBlazorApp.Features.Counters;

  public class Clone_Should : BaseTest
  {
    private CounterState CounterState => Store.GetState<CounterState>();

    public Clone_Should(ClientHost aWebAssemblyHost) : base(aWebAssemblyHost) { }

    public void Clone()
    {
      //Arrange
      CounterState.Initialize(aCount: 15);

      //Act
      var clone = CounterState.Clone() as CounterState;

      //Assert
      CounterState.ShouldNotBeSameAs(clone);
      CounterState.Count.ShouldBe(clone.Count);
      CounterState.Guid.ShouldNotBe(clone.Guid);
    }
  }
}
