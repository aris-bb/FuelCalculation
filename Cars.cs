namespace FuelCalculation
{
    public abstract class Car
    {
        public int Id { get; set; }
        public abstract CarType GetCarType();
    }

    public class Sedan : Car
    {
        public override CarType GetCarType()
        {
            return CarType.Sedan;
        }
    }

    public class SUV : Car
    {
        public override CarType GetCarType()
        {
            return CarType.SUV;
        }
    }

    public class Hatchback : Car
    {
        public override CarType GetCarType()
        {
            return CarType.Hatchback;
        }
    }
}
