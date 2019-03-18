using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        protected double FuelQuantity { get; set; }

        protected double FuelConsumption { get; set; }

        public string Drive(double distance)
        {
            if(this.FuelConsumption * distance <= this.FuelQuantity)
            {
                this.FuelQuantity -= (this.FuelConsumption * distance);

                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public abstract void Refuel(double liters);

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
