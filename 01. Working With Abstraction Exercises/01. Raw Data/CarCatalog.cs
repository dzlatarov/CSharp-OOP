
namespace P01_RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CarCatalog
    {
        private List<Car> cars;

        public CarCatalog()
        {
            this.cars = new List<Car>();
        }

        public void Add(Queue<string> parameters)
        {
            var model = parameters.Dequeue();
            var engineSpeed = int.Parse(parameters.Dequeue());
            var enginePower = int.Parse(parameters.Dequeue());
            var cargoWeight = int.Parse(parameters.Dequeue());
            var cargoType = parameters.Dequeue();

            Engine engine = new Engine(engineSpeed, enginePower);
            Cargo cargo = new Cargo(cargoWeight, cargoType);
            Tire tire = null;
            List<Tire> tires = new List<Tire>();

            if (parameters.Any())
            {
                var pressure = double.Parse(parameters.Dequeue());
                var age = int.Parse(parameters.Dequeue());

                tire = new Tire(pressure, age);
                tires.Add(tire);
            }

            Car car = new Car(model, engine, cargo, tires);
            cars.Add(car);
        }

        public List<Car> GetCars()
        {
            return this.cars;
        }
    }
}
