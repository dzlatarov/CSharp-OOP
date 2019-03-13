﻿
namespace Cars
{
    using Cars.CarsFolder;
    using Cars.Interfaces;
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());
        }
    }
}
