using System.Globalization;

namespace BumbleBikesLibrary.BicycleComponents.Suspensions
{
    public abstract class FullSuspension : AbstractSuspension
    {
        public FullSuspension()
        {
            HasFrontShock = true;
            HasRearShock = true;
        }
    }
}
