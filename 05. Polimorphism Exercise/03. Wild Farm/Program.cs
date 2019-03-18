using System;
using System.Collections.Generic;
using WildFarm.Models.Animals;
using WildFarm.Models.Factories;
using WildFarm.Models.Foods;

namespace WildFarm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            var input = Console.ReadLine();

            while(input != "End")
            {
                var animalArgs = input.Split();
                
                Animal animal = AnimalFactory.CreateAnimal(animalArgs);

                var foodArgs = Console.ReadLine().Split();

                Food food = FoodFactory.CreateFood(foodArgs[0], int.Parse(foodArgs[1]));

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Eat(food);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animals.Add(animal);

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
