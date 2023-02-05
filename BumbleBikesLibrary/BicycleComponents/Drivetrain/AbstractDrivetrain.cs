using System.Globalization;

namespace BumbleBikesLibrary.BicycleComponents.Drivetrain
{
    public enum ShifterTypes
    {
        Paddle,
        Trigger,
        Twist
    }
    public abstract class AbstractDrivetrain : IDrivetrain, IBicycleComponent
    {
        public float CrankLength { get; set; }
        public int FrontCassetteCogs { get; set; }
        public float RearCassetteCogs { get; set; }
        public float ChainLinkCount { get; set; }
        public ShifterTypes Shifter { get; set; }
        public bool IsEnclosed { get; set; }
        public string? Name { get; set; }
        public float Weight { get; set; }
        public float Cost { get; set; }

        public AbstractDrivetrain()
        {
            Name = "Unnamed Component";
        }

        public override string ToString()
        {
            return $@"Your group set consists of a {CrankLength.ToString(CultureInfo.InvariantCulture)} inch crank,
                {FrontCassetteCogs.ToString(CultureInfo.InvariantCulture)} cogs in the front cassette,
                {RearCassetteCogs.ToString(CultureInfo.InvariantCulture)} cogs in the rear cassette,
                and a chain with {ChainLinkCount.ToString(CultureInfo.InvariantCulture)} links in the chain
                and a {Shifter} type shifter";
        }
    }
}
