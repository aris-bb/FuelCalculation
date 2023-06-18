namespace FuelCalculation
{
    public interface IFuelConsumptionCalculator
    {
        double CalculateFuelConsumption(CarType type, double distance);
    }

    public class FuelConsumptionCalculator : IFuelConsumptionCalculator
    {
        private readonly IFuelConsumptionProvider fuelConsumptionProvider;

        public FuelConsumptionCalculator(IFuelConsumptionProvider fuelConsumptionProvider)
        {
            this.fuelConsumptionProvider = fuelConsumptionProvider;
        }

        public double CalculateFuelConsumption(CarType type, double distance)
        {
            double fuelConsumption = fuelConsumptionProvider.GetFuelConsumption(type);
            return fuelConsumption * distance;
        }
    }
}
