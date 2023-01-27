using BumbleBikesLibrary.BicycleComponents.BicycleFrame;
using BumbleBikesLibrary.BicycleComponents.Handlebars;

namespace BicycleAbstractFactory
{
    /// <summary>
    /// An abstraction can refer to an interface or an abstract class.
    /// In this case, the abstract part of the abastract factory is the IBicycleFactory.
    /// </summary>
    public class MountainBicycleFactory : IBicycleFactory
    {
        public IFrame CreateBicycleFrame()
        {
            return new MountainBikeFrame();
        }

        public IHandlebars CreateBicycleHandleBars()
        {
            throw new NotImplementedException();
        }
    }
}
