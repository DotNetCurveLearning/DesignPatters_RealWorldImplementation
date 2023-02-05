using System.Globalization;

namespace BumbleBikesLibrary.BicycleComponents.Suspensions
{
    public abstract class FrontSuspension : AbstractSuspension
    {
        public FrontSuspension()
        {
            HasFrontShock = true;
            HasRearShock = false;
        }
    }
}
