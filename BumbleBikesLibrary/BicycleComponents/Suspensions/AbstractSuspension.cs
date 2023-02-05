using System.Globalization;

namespace BumbleBikesLibrary.BicycleComponents.Suspensions
{
    public abstract class AbstractSuspension : ISuspension
    {
        public bool HasFrontShock { get; set; }
        public bool HasRearShock { get; set; }

        public override string ToString()
        {
            var suspension = Constants.DEFAULT_SUSPENSION;

            if (HasFrontShock && !HasRearShock)
            {
                suspension = Constants.FRONT_SUSPENSION;
            }

            if (HasFrontShock && HasRearShock)
            {
                suspension = Constants.FULL_SUSPENSION;
            }

            return suspension;
        }
    }
}
