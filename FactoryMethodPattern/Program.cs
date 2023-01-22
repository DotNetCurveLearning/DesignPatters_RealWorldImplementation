using FactoryMethodPatter;

Console.WriteLine("Let's make some bicycles");

var dallasBicycleFactory = new DallasFactory();
var phoebesBike = dallasBicycleFactory.CreateProduct("HILLCREST");
phoebesBike.Build();

var alpineBicycleFactory = new AlpineFactory();
var kittyssBike =alpineBicycleFactory.CreateProduct("PALO DURO CANYON RANGER");
kittyssBike.Build();