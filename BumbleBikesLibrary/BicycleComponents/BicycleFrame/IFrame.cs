namespace BumbleBikesLibrary.BicycleComponents.BicycleFrame
{
    public interface IFrame
    {
        string ModelName { get; set; }
        int Year { get; }
        string SerialNumber { get; }
        BicycleGeometries Geometry { get; set; }
        BicyclePaintColors Color { get; set; }
        SuspensionTypes Suspension { get; set; }
        public ManufacturingStatus BuildStatus { get; set; }

        void Build();
    }
}
