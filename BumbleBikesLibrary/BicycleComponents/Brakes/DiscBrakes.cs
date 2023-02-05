using System.Globalization;

namespace BumbleBikesLibrary.BicycleComponents.Brakes
{
    public class DiscBrakes : AbstractBrakes
    {
        public DiscBrakes()
        {
            BrakeType = BicycleBrakeTypes.Disc;
        }
    }
}
