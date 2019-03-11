
namespace Animal
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var animals = new List<Animal>();

            while (true)
            {
                try
                {
                    var animalType = Console.ReadLine();

                    if (animalType == "Beast!")
                    {
                        foreach (var animal in animals)
                        {
                            Console.WriteLine(animal);
                        }

                        break;
                    }

                    var input = Console.ReadLine().Split();
                    var name = input[0];
                    var age = int.Parse(input[1]);
                    var gender = input[2];

                    if (animalType == "Cat")
                    {
                        animals.Add(new Cat(name, age, gender));
                    }
                    else if (animalType == "Dog")
                    {
                        animals.Add(new Dog(name, age, gender));
                    }
                    else if (animalType == "Frog")
                    {
                        animals.Add(new Frog(name, age, gender));
                    }
                    else if (animalType == "Kitten")
                    {
                        animals.Add(new Kitten(name, age));
                    }
                    else if (animalType == "Tomcat")
                    {
                        animals.Add(new Tomcat(name, age));
                    }
                    else
                    {
                        throw new ArgumentException("Invalid input!");
                    }                
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
