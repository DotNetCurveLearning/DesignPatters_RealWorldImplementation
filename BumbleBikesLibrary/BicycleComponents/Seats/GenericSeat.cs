using System.Globalization;

namespace BumbleBikesLibrary.BicycleComponents.Seats
{
    public class GenericSeat : AbstractSeat
    {
        public GenericSeat()
        {
            PaddingThickness = 0.1f;
            SaddleType = SeatSaddleTypes.ModeratlyWaved;
            SpringCount = 0;
        }
    }
}
