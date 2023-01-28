namespace BumbleBikesLibrary.BicycleComponents.BicycleFrame
{
    public class RecumbentFrame : AbstractFrame
    {
        public RecumbentFrame()
        {
            ModelName= "Big Bend";
            Suspension = SuspensionTypes.Front;
            Color = BicyclePaintColors.Blue;
            Geometry = BicycleGeometries.Recumbent;
        }
    }
}
