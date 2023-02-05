using BumbleBikesLibrary.BicycleComponents.BicycleFrame;
using BumbleBikesLibrary.BicycleComponents.Handlebars;

namespace BicycleAbstractFactory
{
    public interface IBicycleFactory
    {
        IFrame CreateBicycleFrame();
        IHandlebars CreateBicycleHandleBars();
    }
}