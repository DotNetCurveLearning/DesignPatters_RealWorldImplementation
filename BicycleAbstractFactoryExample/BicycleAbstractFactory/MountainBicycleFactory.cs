using BumbleBikesLibrary.BicycleComponents.BicycleFrame;
using BumbleBikesLibrary.BicycleComponents.Handlebars;

namespace BicycleAbstractFactory
{
    public class MountainBicycleFactory : IBicycleFactory
    {
        public IFrame CreateBicycleFrame()
        {
            return new MountainBikeFrame();
        }
        public IHandlebars CreateBicycleHandleBars()
        {
            return new MountainBikeHandlebars();
        }
    }
}