namespace BumbleBikesLibrary.BicycleComponents.BicycleFrame
{
    public class RoadBikeFrame : AbstractFrame
    {
        public RoadBikeFrame()
        {
            ModelName= "Hillcrest";
            Suspension = SuspensionTypes.Hardtail;
            Color = BicyclePaintColors.Blue;
            Geometry = BicycleGeometries.Upright;
        }
    }
}
