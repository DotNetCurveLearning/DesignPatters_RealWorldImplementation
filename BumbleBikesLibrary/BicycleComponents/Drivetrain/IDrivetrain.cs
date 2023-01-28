namespace BumbleBikesLibrary.BicycleComponents.Drivetrain
{
    public interface IDrivetrain
    {
        float CrankLength { get; set; }
        int FrontCassetteCogs { get; set; }
        float RearCassetteCogs { get; set; }
        float ChainLinkCount { get; set; }
        ShifterTypes Shifter { get; set; }
        bool IsEnclosed { get; set; }
    }
}
