using System.Threading;
using BumbleBikesLibrary;
using FactoryMethodPattern;

/// <summary>
/// Concrete creators (factories subclasses) provide
/// the actual concrete classes.
/// All the creation logic will be here to produce
/// road bikes and recumbent bikes.
/// </summary>
namespace FactoryMethodPatter
{
    public class DallasFactory : BicycleFactory
    {
        public override IBicycle CreateProduct(string modelName)
        {
            return modelName.ToLowerInvariant() switch
            {
                "hillcrest" => new RoadBike(),
                "big bend" => new Recumbent(),
                _ => throw new Exception("Invalid bicycle model")
            };
        }
    }
}