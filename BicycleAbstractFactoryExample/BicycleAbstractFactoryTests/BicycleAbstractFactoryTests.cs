using Xunit;
using Moq;
using FluentAssertions;
using BicycleAbstractFactory;
using BumbleBikesLibrary.BicycleComponents.BicycleFrame;

namespace BicycleAbstractFactoryTests;

public class BicycleAbstractFactoryTests
{
    private IBicycleFactory mountainBicycleFactory = new MountainBicycleFactory();
    private IBicycleFactory roadBicycleFactory = new RoadBicycleFactory();

    [Fact]
    public void WhenMountainBicycleFactoryCreateBicycleFrame_ThenReturnsAnInstanceOfMountainBikeFrame()
    {
        // arrange

        // act
        var result = mountainBicycleFactory.CreateBicycleFrame();

        // assert
        result.Should().NotBeNull();
        result.Should().BeOfType<MountainBikeFrame>();
    }

    [Fact]
    public void WhenMountainBicycleFactoryCreateBicycleHandleBars_ThenReturnsAnInstanceOfMountainBikeHandlebars()
    {
        // arrange

        // act
        var result = mountainBicycleFactory.CreateBicycleHandleBars();

        // assert
        result.Should().NotBeNull();
        result.Should().BeOfType<MountainBikeHandlebars>();
    }

    [Fact]
    public void WhenRoadBicycleFactoryCreateBicycleFrame_ThenReturnsAnInstanceOfMountainBikeFrame()
    {
        // arrange

        // act
        var result = roadBicycleFactory.CreateBicycleFrame();

        // assert
        result.Should().NotBeNull();
        result.Should().BeOfType<RoadBikeFrame>();
    }

    [Fact]
    public void WhenRoadBicycleFactoryCreateBicycleHandleBars_ThenReturnsAnInstanceOfMountainBikeHandlebars()
    {
        // arrange

        // act
        var result = roadBicycleFactory.CreateBicycleHandleBars();

        // assert
        result.Should().NotBeNull();
        result.Should().BeOfType<RoadBikeHandlebars>();
    }
}