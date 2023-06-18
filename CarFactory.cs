namespace FuelCalculation
{
    public interface ICarFactory
    {
        Car CreateCar(CarType type);
    }

    public enum CarType
    {
        Sedan,
        SUV,
        Hatchback
    }

    public class CarFactory : ICarFactory
    {
        public Car CreateCar(CarType type)
        {
            return type switch
            {
                CarType.Sedan => new Sedan(),
                CarType.SUV => new SUV(),
                CarType.Hatchback => new Hatchback(),
                _ => throw new ArgumentException("Invalid car type"),
            };
        }
    }
}
