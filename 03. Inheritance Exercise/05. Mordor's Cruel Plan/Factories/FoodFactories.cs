
using MordorsCruelPlan.Foods;

namespace MordorsCruelPlan.Factories
{
    public class FoodFactories
    {
        public Food CreateFood(string type)
        {
            switch(type.ToLower())
            {
                case "apple":
                    return new Apple();

                case "cram":
                    return new Cram();

                case "lembas":
                    return new Lembas();

                case "melon":
                    return new Melon();

                case "honeycake":
                    return new HoneyCake();

                case "mushrooms":
                    return new Mushrooms();

                default:
                    return new OtherFood();
            }
        }
    }
}
