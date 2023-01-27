using BumbleBikesLibrary;

/// <summary>
/// A factory method has a Creator (Factory) class that houses
/// the factory method itself.
/// The Factory Method is coded to return the Product interface
/// so that it can return any product that implements that interface.
/// It isn't tied to a particular abstrac base class.
/// These creators are abstract and are meant to be overriden in
/// concrete creator (factories) subclasses.
/// </summary>
namespace FactoryMethodPattern
{
    public abstract class BicycleFactory
    {
        public abstract IBicycle CreateProduct(string modelName);
    }
}