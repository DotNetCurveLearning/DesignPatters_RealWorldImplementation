using System.Runtime.CompilerServices;

namespace BumbleBikesLibrary
{
    [Flags]
    public enum BicycleGeometries
    {
        None = 0,
        Upright = 1,
        Recumbent = 2
    }

    [Flags]
    public enum BicyclePaintColors
    {
        None = 0,
        Black = 1,
        Red = 2,
        White = 4,
        Blue = 8
    }

    [Flags]
    public enum ManufacturingStatus
    {
        None = 0,
        Specified = 1,
        FrameManufactured = 2,
        Painted = 4,
        SuspensionMounted = 8,
        Complete = 16
    }

    [Flags]
    public enum SuspensionTypes
    {
        None = 0,
        Full = 1,
        Front = 2,
        Hardtail = 4
    }

    /// <summary>
    /// This abstract class implements the IBicycle interface.
    /// This allow us to pass the interface around, which is more
    /// flexible than using this base class.
    /// </summary>
    public abstract class Bicycle : IBicycle
    {
        public string ModelName { get; set; }
        public int Year { get; }
        public string SerialNumber { get; set; }
        public BicyclePaintColors Color { get; set; }
        public BicycleGeometries Geometry { get; set; }
        public SuspensionTypes Suspension { get; set; }
        public ManufacturingStatus BuildStatus { get; set; }

        public Bicycle()
        {
            ModelName = string.Empty; // will be filled in sublcass constructor
            SerialNumber = Guid.NewGuid().ToString();
            Year = DateTime.Now.Year;
            BuildStatus = ManufacturingStatus.Specified;
        }
        public void Build()
        {
            Console.WriteLine($"Manufacturing a {Geometry.ToString()} frame...");
            BuildStatus = ManufacturingStatus.FrameManufactured;
            PrintBuildStatus();

            Console.WriteLine($"Painting the frame {Color.ToString()}");
            BuildStatus = ManufacturingStatus.Painted;
            PrintBuildStatus();

            if (Suspension != SuspensionTypes.Hardtail)
            {
                Console.WriteLine($"Mounting the {Suspension.ToString()} suspension.");
                BuildStatus = ManufacturingStatus.SuspensionMounted;
                PrintBuildStatus();
            }

            Console.WriteLine("{0} {1} Bicycle serial number {2} manufacturing complete!",
                Year, ModelName, SerialNumber);
            BuildStatus = ManufacturingStatus.Complete;
            PrintBuildStatus();
        }

        private void PrintBuildStatus()
        {
            Console.WriteLine($"Status: {BuildStatus.ToString()}");
        }
        public override string ToString()
        {
            return $"Your bicycle is a {Color.ToString()} {ModelName}, with a {Suspension.ToString()} suspension and a(n) {Geometry.ToString()} geometry.";
        }
    }
}