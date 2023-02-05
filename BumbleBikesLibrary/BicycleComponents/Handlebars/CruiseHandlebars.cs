namespace BumbleBikesLibrary.BicycleComponents.BicycleFrame
{
    public class CruiseHandlebars : AbstractHandlebars
    {
        public CruiseHandlebars()
        {
            // units are imperial
            Length = 32.6f;
            Diameter = 1.0f;
            IsDropped = false;
            RiseAngle = 6.35f;
        }
    }
}
