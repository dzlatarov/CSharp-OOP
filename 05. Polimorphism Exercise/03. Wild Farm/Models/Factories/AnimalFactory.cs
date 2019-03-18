using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Animals;
using WildFarm.Models.Animals.Birds;
using WildFarm.Models.Animals.Felines;
using WildFarm.Models.Animals.Mammals;

namespace WildFarm.Models.Factories
{
    public static class AnimalFactory
    {
        public static Animal CreateAnimal(string[] animalArgs)
        {
            switch(animalArgs[0])
            {
                case "Hen":
                    return new Hen(animalArgs[1], double.Parse(animalArgs[2]), double.Parse(animalArgs[3]));

                case "Owl":
                    return new Owl(animalArgs[1], double.Parse(animalArgs[2]), double.Parse(animalArgs[3]));

                case "Cat":
                    return new Cat(animalArgs[1], double.Parse(animalArgs[2]), animalArgs[3], animalArgs[4]);

                case "Tiger":
                    return new Tiger(animalArgs[1], double.Parse(animalArgs[2]), animalArgs[3], animalArgs[4]);

                case "Dog":
                    return new Dog(animalArgs[1], double.Parse(animalArgs[2]), animalArgs[3]);

                case "Mouse":
                    return new Mouse(animalArgs[1], double.Parse(animalArgs[2]), animalArgs[3]);

                default:
                    throw new ArgumentException("Invalid type of animal!");
            }
        }
    }
}
