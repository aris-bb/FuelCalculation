namespace FuelCalculation
{
    public interface IFuelConsumptionProvider
    {
        double GetFuelConsumption(CarType type);
    }

    public class FuelConsumptionProvider : IFuelConsumptionProvider
    {
        private static FuelConsumptionProvider instance;
        private readonly Dictionary<CarType, double> fuelConsumptionData;

        private FuelConsumptionProvider()
        {
            fuelConsumptionData = new Dictionary<CarType, double>
            {
                { CarType.Sedan, 8.5 },
                { CarType.SUV, 12.0 },
                { CarType.Hatchback, 6.0 }
            };
        }

        public static FuelConsumptionProvider GetInstance()
        {
            instance ??= new FuelConsumptionProvider();

            return instance;
        }

        public double GetFuelConsumption(CarType type)
        {
            if (fuelConsumptionData.ContainsKey(type))
            {
                return fuelConsumptionData[type];
            }

            throw new ArgumentException("Fuel consumption data not found for car type: " + type);
        }
    }
}
