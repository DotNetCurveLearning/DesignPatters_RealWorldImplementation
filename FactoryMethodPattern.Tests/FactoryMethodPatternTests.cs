using FactoryMethodPatter;
using Xunit;
using AutoFixture;
using Moq;
using BumbleBikesLibrary;
using FluentAssertions;

namespace FactoryMethodPattern.Tests;

public class FactoryMethodPatternTests
{
    private readonly Mock<AlpineFactory> alpineFactoryMock = new Mock<AlpineFactory>();
    private readonly Mock<DallasFactory> dallasFactoryMock = new Mock<DallasFactory>();

    [Fact]
    public void WhenModelNameEqualsPaloDuro_ThenAlpineFactoryShouldCreateMountainBike()
    {
        // arrange
        alpineFactoryMock.Setup(af => af.CreateProduct("palo duro canyon ranger"))
            .Returns(new MountainBike());

        // act
        var result = alpineFactoryMock.Object.CreateProduct("palo duro canyon ranger");
        result.Build();


        // assert
        result.Should().NotBeNull();
        result.Should().BeOfType<MountainBike>();
    }

    [Fact]
    public void WhenModelNameEqualsGalvestonCruiser_ThenAlpineFactoryShouldCreateCruiser()
    {
        // arrange
        alpineFactoryMock.Setup(af => af.CreateProduct("galveston cruiser"))
            .Returns(new Cruiser());

        // act
        var result = alpineFactoryMock.Object.CreateProduct("galveston cruiser");
        result.Build();


        // assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Cruiser>();
    }

    [Fact]
    public void WhenModelNameEqualsHillCrest_ThenDallasFactoryShouldCreateRoadBike()
    {
        // arrange
        dallasFactoryMock.Setup(df => df.CreateProduct("hillcrest"))
            .Returns(new RoadBike());

        // act
        var result = dallasFactoryMock.Object.CreateProduct("hillcrest");
        result.Build();


        // assert
        result.Should().NotBeNull();
        result.Should().BeOfType<RoadBike>();
    }

    [Fact]
    public void WhenModelNameEqualsRecumbent_ThenDallasFactoryShouldCreateRecumbent()
    {
        // arrange
        alpineFactoryMock.Setup(df => df.CreateProduct("recumbent"))
            .Returns(new Recumbent());

        // act
        var result = alpineFactoryMock.Object.CreateProduct("recumbent");
        result.Build();


        // assert
        result.Should().NotBeNull();
        result.Should().BeOfType<Recumbent>();
    }
}