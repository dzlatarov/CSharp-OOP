
namespace HotelReservation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public  class PriceCalculator
    {
        private decimal pricePerDay;
        private int days;
        private Season season;
        private Discount discount;

        public PriceCalculator(string[] input)
        {
            this.pricePerDay = decimal.Parse(input[0]);
            this.days = int.Parse(input[1]);
            this.season = Enum.Parse<Season>(input[2]);
            this.discount = Discount.None;

            if(input.Length == 4)
            {
                this.discount = Enum.Parse<Discount>(input[3]);
            }
        }

        public decimal GetPrice()
        {
            return (this.pricePerDay * this.days * (int)this.season) * (1 - (decimal)discount / 100);
        }
    }
}
