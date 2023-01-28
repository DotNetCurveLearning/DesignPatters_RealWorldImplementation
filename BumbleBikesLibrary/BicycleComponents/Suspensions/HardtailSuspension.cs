using System.Globalization;

namespace BumbleBikesLibrary.BicycleComponents.Suspensions
{
    public abstract class HardtailSuspension : AbstractSuspension
    {
        public HardtailSuspension()
        {
            HasFrontShock = false;
            HasRearShock = false;
        }
    }
}
