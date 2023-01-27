using BumbleBikesLibrary.BicycleComponents.BicycleFrame;
using BumbleBikesLibrary.BicycleComponents.Handlebars;

namespace BicycleAbstractFactory
{
    public interface IBicycleFactory
    {
        public IFrame CreateBicycleFrame();
        public IHandlebars CreateBicycleHandleBars();
    }
}
