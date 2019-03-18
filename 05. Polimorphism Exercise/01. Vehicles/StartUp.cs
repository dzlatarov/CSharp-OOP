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

            Car car = new Car(carFuelQuantity, carFuelConsumption);

            var truckArgs = Console.ReadLine().Split();
            var truckFuelQuantity = double.Parse(truckArgs[1]);
            var truckFuelConsumption = double.Parse(truckArgs[2]);

            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption);

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
                            car.Refuel(liters);
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
                            truck.Refuel(liters);
                        }

                        break;

                    default:
                        Console.WriteLine("Invalid type!");
                        break;
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
