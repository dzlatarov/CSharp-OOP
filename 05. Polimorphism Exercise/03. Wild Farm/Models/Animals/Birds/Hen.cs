using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            this.Weight += (food.Quantity * 0.35);
            this.FoodEaten += food.Quantity;
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }

        public override string ToString()
        {
            return $"{base.ToString()}{this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
