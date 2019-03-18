using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override string Drive(double distance)
        {
            if((this.FuelConsumption + 1.4) * distance <= this.FuelQuantity)
            {
                this.FuelQuantity -= ((this.FuelConsumption + 1.4) * distance);
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public string DriveEmpty(double distance)
        {
            return base.Drive(distance);
        }
    }
}
