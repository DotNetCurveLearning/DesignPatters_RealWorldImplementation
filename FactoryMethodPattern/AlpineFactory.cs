using System.Threading;
using BumbleBikesLibrary;
using FactoryMethodPattern;

/// <summary>
/// Concrete creators (factories subclasses) provide
/// the actual concrete classes.
/// All the creation logic will be here, to produce
/// mountain bikes and cruisers.
/// </summary>
namespace FactoryMethodPatter
{
    public class AlpineFactory : BicycleFactory
    {
        public override IBicycle CreateProduct(string modelName)
        {
            return modelName.ToLowerInvariant() switch
            {
                "palo duro canyon ranger" => new MountainBike(),
                "big bend" => new Recumbent(),
                _ => throw new Exception("Invalid bicycle model")
            };
        }
    }
}