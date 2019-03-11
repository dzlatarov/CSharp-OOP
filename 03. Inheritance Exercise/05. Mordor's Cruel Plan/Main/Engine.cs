
namespace MordorsCruelPlan.Main
{
    using MordorsCruelPlan.Factories;
    using MordorsCruelPlan.Foods;
    using MordorsCruelPlan.Moods;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private FoodFactories foodFactories;
        private MoodFactories MoodFactories;
        private List<Food> foods = new List<Food>();

        public Engine()
        {
            this.foodFactories = new FoodFactories();
            this.MoodFactories = new MoodFactories();
            this.foods = new List<Food>();
        }

        public void Run()
        {
            var input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

            foreach (var type in input)
            {
                Food food = foodFactories.CreateFood(type);
                foods.Add(food);
            }

            var points = foods.Sum(x => x.Happiness);
            Mood mood;

            if(points < -5)
            {
                mood = MoodFactories.CreateMood("angry");
            }
            else if(points >= -5 && points <= 0)
            {
                mood = MoodFactories.CreateMood("sad");
            }
            else if(points > 0 && points <= 15)
            {
                mood = MoodFactories.CreateMood("happy");
            }
            else
            {
                mood = MoodFactories.CreateMood("javascript");
            }

            Console.WriteLine(points);
            Console.WriteLine(mood.Name);
        }
    }
}
