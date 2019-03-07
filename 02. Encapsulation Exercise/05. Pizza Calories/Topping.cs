
namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Topping
    {
        private const double BaseCaloriesPerGram = 2;
        private string type;
        private double weight;
        private Dictionary<string, double> validTypes;


        public Topping(string type, double weight)
        {
            this.validTypes = new Dictionary<string, double>();
            this.SeedType();
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get => this.type;
            set
            {
                if (!validTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }


        private void SeedType()
        {
            this.validTypes.Add("meat", 1.2);
            this.validTypes.Add("veggies", 0.8);
            this.validTypes.Add("cheese", 1.1);
            this.validTypes.Add("sauce", 0.9);
        }

        public double CalculateCalories()
        {
            return BaseCaloriesPerGram * this.Weight * this.validTypes[this.Type.ToLower()];
        }
    }
}
