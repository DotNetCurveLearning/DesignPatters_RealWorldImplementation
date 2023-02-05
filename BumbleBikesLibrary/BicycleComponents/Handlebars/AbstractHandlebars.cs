using System.Globalization;
using BumbleBikesLibrary.BicycleComponents.Handlebars;

namespace BumbleBikesLibrary.BicycleComponents.BicycleFrame
{
    public abstract class AbstractHandlebars : IHandlebars
    {
        public float Length { get; set; }
        public float Diameter { get; set; }
        public bool IsDropped { get; set; }
        public float RiseAngle { get; set; }

        public override string ToString()
        {
            var isDroppedText = Constants.DROPPED_VALUE;

            if (IsDropped)
            {
                isDroppedText = Constants.NOT_DROPPED_VALUE;
            }

            return $@"Your {isDroppedText} handlebars are {Length.ToString(CultureInfo.InvariantCulture)} wide,
                {Diameter.ToString(CultureInfo.InvariantCulture)} in diameter,
                with a rise angle of {RiseAngle.ToString(CultureInfo.InvariantCulture)}";
        }
    }
}
