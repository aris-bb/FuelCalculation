using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalculation
{
    public interface ICarRepository
    {
        Car GetCarById(int id);
        List<Car> GetAllCars();
        List<Car> GetCarsByType(CarType type);
        void AddCar(Car car);
        void RemoveCar(int id);
    }

    public class CarRepository : ICarRepository
    {
        private List<Car> carList;

        public CarRepository()
        {
            carList = new List<Car>();
        }

        public Car GetCarById(int id)
        {
            return carList.Find(car => car.Id == id);
        }

        public List<Car> GetAllCars()
        {
            return carList;
        }

        public List<Car> GetCarsByType(CarType type)
        {
            return carList.FindAll(car => car.GetCarType() == type);
        }

        public void AddCar(Car car)
        {
            carList.Add(car);

            // Set car id
            car.Id = carList.Count;
        }

        public void RemoveCar(int id)
        {
            Car carToRemove = GetCarById(id);
            if (carToRemove != null)
            {
                carList.Remove(carToRemove);
            }
        }
    }
}
