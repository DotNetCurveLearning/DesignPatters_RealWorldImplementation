namespace BumbleBikesLibrary.BicycleComponents.Seats
{
    public interface ISeat
    {
        SeatSaddleTypes SaddleType { get; set; }
        float PaddingThickness { get; set; }
        int SpringCount { get; set; }
    }
}
