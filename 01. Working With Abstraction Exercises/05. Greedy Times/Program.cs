using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class Potato
    {
        static void Main(string[] args)
        {
            var capacity = long.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Bag(capacity);

            for (int i = 0; i < input.Length; i += 2)
            {
                var key = input[i];
                var value = long.Parse(input[i + 1]);

                InsertItem(key, value, bag);
            }

            Console.WriteLine(bag.ToString());

        }

        private static void InsertItem(string key, long value, Bag bag)
        {
            if (key.Length == 3)
            {
                var cash = new CashItem(key, value);
                bag.AddCashItem(cash);
            }
            else if (key.Length >= 4 && key.ToLower().EndsWith("gem"))
            {
                var gem = new GemItem(key, value);
                bag.AddGemItem(gem);
            }
            else if (key.ToLower().Equals("gold"))
            {
                var gold = new GoldItem(key, value);
                bag.AddGoldItem(gold);
            }
        }
    }
}