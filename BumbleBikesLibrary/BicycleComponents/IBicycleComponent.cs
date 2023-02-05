namespace BumbleBikesLibrary.BicycleComponents
{
    public interface IBicycleComponent
    {
        string? Name { get; set; }
        float Weight { get; set; }
        float Cost { get; set; }
    }
}