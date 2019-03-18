using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Factories
{
    public static class FoodFactory
    {
        public static Food CreateFood(string type, int quantity)
        {
            switch(type)
            {
                case "Fruit":
                    return new Fruit(quantity);
                                
                case "Meat":
                    return new Meat(quantity);
                   
                case "Seeds":
                    return new Seeds(quantity);
                    
                case "Vegetable":
                    return new Vegetable(quantity);

                default:
                    throw new ArgumentException("Invalid type of food!");
            }
        }
    }
}
