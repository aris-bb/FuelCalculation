namespace FuelCalculation
{
    public interface ICarCommand<TResult>
    {
        void Execute();
        TResult GetResult();
    }

    public class CalculateFuelConsumptionCommand : ICarCommand<double>
    {
        private readonly Car car;
        private readonly double distance;
        private readonly IFuelConsumptionCalculator fuelConsumptionCalculator;

        private double calculatedFuelConsumption;

        public CalculateFuelConsumptionCommand(Car car, double distance, IFuelConsumptionCalculator fuelConsumptionCalculator)
        {
            this.car = car;
            this.distance = distance;
            this.fuelConsumptionCalculator = fuelConsumptionCalculator;
        }

        public void Execute()
        {
            calculatedFuelConsumption = fuelConsumptionCalculator.CalculateFuelConsumption(car.GetCarType(), distance);
        }

        public double GetResult()
        {
            return calculatedFuelConsumption;
        }
    }
}
