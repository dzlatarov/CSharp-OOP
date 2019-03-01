
namespace RhombusOfStars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RhombusOfStars
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                PrintRow(size, i);
            }

            for (int i = size - 1; i >= 1; i--)
            {
                PrintRow(size, i);
            }
        }

        private static void PrintRow(int size, int starCount)
        {
            for (int j = 0; j < size - starCount; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k < starCount; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("*");
        }
    }
}
