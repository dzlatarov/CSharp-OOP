
namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PizzaCalories
    {
        public static void Main(string[] args)
        {            
            try
            {
                var pizzaArgs = Console.ReadLine().Split();
                string pizzaName = pizzaArgs[1];

                var doughArgs = Console.ReadLine().Split();

                string flourType = doughArgs[1];
                string bakingTechnique = doughArgs[2];
                double weight = double.Parse(doughArgs[3]);

                Dough dough = new Dough(flourType, bakingTechnique, weight);

                Pizza pizza = new Pizza(pizzaName, dough);

                string inputLine = Console.ReadLine();
                
                while(inputLine != "END")
                {
                    var toppingArgs = inputLine.Split();
                    string type = toppingArgs[1];
                    double toppingWeight = double.Parse(toppingArgs[2]);

                    Topping topping = new Topping(type, toppingWeight);

                    pizza.AddTopping(topping);

                    inputLine = Console.ReadLine();
                }                

                Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories().ToString("f2")} Calories.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }
    }
}
