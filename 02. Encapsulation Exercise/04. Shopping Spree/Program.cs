namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingSpree
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            foreach (var item in input)
            {
               string[] tokens = item.Split('=');

                try
                {
                    persons.Add(new Person(tokens[0], decimal.Parse(tokens[1])));
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            input = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in input)
            {
                var tokens = item.Split('=');

                try
                {
                    products.Add(new Product(tokens[0], decimal.Parse(tokens[1])));
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split(' ');

                string personName = tokens[0];
                string productName = tokens[1];

                var person = persons.Single(x => x.Name == personName);
                var product = products.Single(p => p.Name == productName);

                if(!person.BuyProduct(product))
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
            }

            foreach (var item in persons)
            {
                string productBought = item.BagOfProducts.Count == 0 ? "Nothing bought" : string.Join(", ", item.BagOfProducts.Select(p => p.Name));
                Console.WriteLine($"{item.Name} - {productBought}");
            }
        }
    }
}
