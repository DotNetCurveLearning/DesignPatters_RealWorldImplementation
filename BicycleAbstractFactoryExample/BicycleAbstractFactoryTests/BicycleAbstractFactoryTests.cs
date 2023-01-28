using Xunit;
using Moq;
using FluentAssertions;
using BicycleAbstractFactory;
using BumbleBikesLibrary.BicycleComponents.BicycleFrame;

namespace BicycleAbstractFactoryTests;

public class BicycleAbstractFactoryTests
{
    private IBicycleFactory mountainBicycleFactory = new MountainBicycleFactory();

    [Fact]
    public void WhenCreateBicycleFrameIsInvoked_ThenReturnsAnInstanceOfMountainBikeFrame()
    {
        // arrange

        // act
        var result = mountainBicycleFactory.CreateBicycleFrame();

        // assert
        result.Should().NotBeNull();
        result.Should().BeOfType<MountainBikeFrame>();
    }

    [Fact]
    public void WhenCreateBicycleHandleBarsIsInvoked_ThenReturnsAnInstanceOfMountainBikeHandlebars()
    {
        // arrange

        // act
        var result = mountainBicycleFactory.CreateBicycleHandleBars();

        // assert
        result.Should().NotBeNull();
        result.Should().BeOfType<MountainBikeHandlebars>();
    }


}