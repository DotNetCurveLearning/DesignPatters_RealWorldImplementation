namespace BumbleBikesLibrary.BicycleComponents.BicycleFrame
{
    public class CruiserFrame : AbstractFrame
    {
        public CruiserFrame()
        {
            ModelName= "Galveston Cruiser";
            Suspension = SuspensionTypes.Hardtail;
            Color = BicyclePaintColors.Red;
            Geometry = BicycleGeometries.Upright;
        }
    }
}
