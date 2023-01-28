using System.Globalization;

namespace BumbleBikesLibrary.BicycleComponents.Seats
{
    public class RecumbentSeat : AbstractSeat
    {
        public RecumbentSeat()
        {
            PaddingThickness = 0.5f;
            SaddleType = SeatSaddleTypes.LazyBoyRecliner;
            SpringCount = 6;
        }
    }
}
