using System;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var carArgs = Console.ReadLine().Split();
            var carFuelQuantity = double.Parse(carArgs[1]);
            var carFuelConsumption = double.Parse(carArgs[2]);
            var carTankCapacity = double.Parse(carArgs[3]);

            Car car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);

            var truckArgs = Console.ReadLine().Split();
            var truckFuelQuantity = double.Parse(truckArgs[1]);
            var truckFuelConsumption = double.Parse(truckArgs[2]);
            var truckTankCapacity = double.Parse(truckArgs[3]);

            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption,truckTankCapacity);

            var busArgs = Console.ReadLine().Split();
            var busFuelQuantity = double.Parse(busArgs[1]);
            var busFuelConsumption = double.Parse(busArgs[2]);
            var busTankCapacity = double.Parse(busArgs[3]);

            Bus bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

            var countCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCommands; i++)
            {
                var input = Console.ReadLine().Split();
                var command = input[0];
                var type = input[1];

                switch(type)
                {
                    case "Car":
                        if(command == "Drive")
                        {
                            var distance = double.Parse(input[2]);
                            Console.WriteLine(car.Drive(distance));
                        }
                        else if(command == "Refuel")
                        {
                            var liters = double.Parse(input[2]);
                            try
                            {
                                car.Refuel(liters);

                            }
                            catch(ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }                            
                        }

                        break;

                    case "Truck":
                        if(command == "Drive")
                        {
                            var distance = double.Parse(input[2]);
                            Console.WriteLine(truck.Drive(distance));
                        }
                        else if(command == "Refuel")
                        {
                            var liters = double.Parse(input[2]);
                            try
                            {
                                truck.Refuel(liters);
                            }
                            catch(ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }                            
                        }

                        break;

                    case "Bus":
                        if(command == "Drive")
                        {
                            var distance = double.Parse(input[2]);
                            Console.WriteLine(bus.Drive(distance));
                        }
                        else if(command == "DriveEmpty")
                        {
                            var distance = double.Parse(input[2]);
                            Console.WriteLine(bus.DriveEmpty(distance));
                        }
                        else if(command == "Refuel")
                        {
                            var liters = double.Parse(input[2]);
                            try
                            {
                                bus.Refuel(liters);
                            }
                            catch(ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }                            
                        }

                        break;

                    default:
                        Console.WriteLine("Invalid type!");
                        break;
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
