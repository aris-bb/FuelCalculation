using FuelCalculation;

ICarFactory carFactory = new CarFactory();
ICarRepository carRepository = new CarRepository();

IFuelConsumptionProvider fuelConsumptionProvider = FuelConsumptionProvider.GetInstance();
IFuelConsumptionCalculator fuelConsumptionCalculator = new FuelConsumptionCalculator(fuelConsumptionProvider);

carRepository.AddCar(carFactory.CreateCar(CarType.Sedan));
carRepository.AddCar(carFactory.CreateCar(CarType.SUV));
carRepository.AddCar(carFactory.CreateCar(CarType.Hatchback));

Car car = carRepository.GetCarById(1);

Console.WriteLine("Car type: " + car.GetCarType());

ICarCommand<double> calculateFuelConsumptionCommand = new CalculateFuelConsumptionCommand(car, 100, fuelConsumptionCalculator);
calculateFuelConsumptionCommand.Execute();

Console.WriteLine("Fuel consumption: " + calculateFuelConsumptionCommand.GetResult());