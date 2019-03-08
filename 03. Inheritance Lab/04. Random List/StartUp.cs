using System;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var randomList = new RandomList();

            randomList.Add("1");
            randomList.Add("2");
            randomList.Add("3");

            Console.WriteLine(randomList.RandomString());
        }
    }
}
