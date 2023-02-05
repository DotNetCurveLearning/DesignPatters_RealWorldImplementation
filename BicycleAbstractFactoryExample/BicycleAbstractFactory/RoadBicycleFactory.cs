using BumbleBikesLibrary.BicycleComponents.BicycleFrame;
using BumbleBikesLibrary.BicycleComponents.Handlebars;

namespace BicycleAbstractFactory
{
    public class RoadBicycleFactory : IBicycleFactory
    {
        public IFrame CreateBicycleFrame()
        {
            return new RoadBikeFrame();
        }
        public IHandlebars CreateBicycleHandleBars()
        {
            return new RoadBikeHandlebars();
        }
    }
}