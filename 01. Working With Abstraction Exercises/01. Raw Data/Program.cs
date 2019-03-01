using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
    public class RawData
    {
        public static void Main(string[] args)
        {            
            int lines = int.Parse(Console.ReadLine());

            var carCatalog = new CarCatalog();

            for (int i = 0; i < lines; i++)
            {
                var parameters = new Queue<string>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));

                carCatalog.Add(parameters);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<string> fragile = carCatalog.GetCars()
                    .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = carCatalog.GetCars()
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }
    }
}
