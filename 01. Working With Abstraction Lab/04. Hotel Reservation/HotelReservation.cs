
namespace HotelReservation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HotelReservation
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            PriceCalculator priceCalculator = new PriceCalculator(input);

            var totalPrice = priceCalculator.GetPrice();
            Console.WriteLine(totalPrice.ToString("F2"));
        }
    }
}
