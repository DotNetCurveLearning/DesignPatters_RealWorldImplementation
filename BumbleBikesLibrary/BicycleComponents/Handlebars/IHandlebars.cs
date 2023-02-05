namespace BumbleBikesLibrary.BicycleComponents.Handlebars
{
    public interface IHandlebars
    {
        float Length { get; set; }
        float Diameter { get; set; }
        bool IsDropped { get; set; }
        float RiseAngle { get; set; }
    }
}
