
namespace FoodShortage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var buyers = new List<IBuyer>();
            var numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var input = Console.ReadLine().Split();

                if (input.Length == 4)
                {
                    buyers.Add(new Citizen(input[0], int.Parse(input[1]), input[2], input[3]));
                }

                else if (input.Length == 3)
                {
                    buyers.Add(new Rebel(input[0], int.Parse(input[1]), input[2]));
                }
            }

            while (true)
            {
                var peopleBuyingFood = Console.ReadLine();

                if (peopleBuyingFood == "End")
                {
                    var totalSum = buyers.Sum(x => x.Food);
                    Console.WriteLine(totalSum);
                    break;
                }

                var validPerson = buyers.FirstOrDefault(p => p.Name == peopleBuyingFood);

                if (validPerson != null)
                {
                    validPerson.BuyFood();
                }
            }
        }
    }
}
