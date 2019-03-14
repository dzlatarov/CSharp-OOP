using System;

namespace Ferrari
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var driver = Console.ReadLine();

            var ferrari = new Ferrari(driver);

            Console.WriteLine(ferrari);
        }
    }
}
