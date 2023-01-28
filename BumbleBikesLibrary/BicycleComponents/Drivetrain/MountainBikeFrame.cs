namespace BumbleBikesLibrary.BicycleComponents.BicycleFrame
{
    public class MountainBikeFrame : AbstractFrame
    {
        public MountainBikeFrame()
        {
            ModelName= "Palo Duro Canyon Ranger";
            Suspension = SuspensionTypes.Full;
            Color = BicyclePaintColors.Black;
            Geometry = BicycleGeometries.Upright;
        }
    }
}
