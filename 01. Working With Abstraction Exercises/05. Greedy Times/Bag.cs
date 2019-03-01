
namespace P05_GreedyTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Bag
    {
        private List<Item> bag;
        private long capacity;
        private long current;

        public Bag(long capacity)
        {
            this.capacity = capacity;
            this.bag = new List<Item>();
        }

        public long GoldItemsValue
        {
            get
            {
                return this.bag.Where(i => i is GoldItem).Sum(i => i.Value);
            }
        }

        public long CashItemsValue
        {
            get
            {
                return this.bag.Where(i => i is CashItem).Sum(i => i.Value);
            }
        }

        public long GemItemsValue
        {
            get
            {
                return this.bag.Where(i => i is GemItem).Sum(i => i.Value);
            }
        }

        public void AddGoldItem(GoldItem item)
        {
            if(this.capacity >= this.current + item.Value)
            {
                var goldItems = GetGoldItems();
                if(goldItems.Any(x => x.Key == item.Key))
                {
                    goldItems.Single(x => x.Key == item.Key).IncreasingValue(item.Value);
                }
                else
                {
                    this.bag.Add(item);
                }

                this.current += item.Value;
            }
        }

        public void AddCashItem(CashItem item)
        {
            if(this.capacity >= this.current + item.Value && GemItemsValue >= CashItemsValue + item.Value)
            {
                var cashItems = GetCashItems();
                if(cashItems.Any(x => x.Key == item.Key))
                {
                    cashItems.Single(x => x.Key == item.Key).IncreasingValue(item.Value);
                }
                else
                {
                    this.bag.Add(item);
                }

                this.current += item.Value;
            }
        }

        public void AddGemItem(GemItem item)
        {
            if(this.capacity >= this.current + item.Value && GoldItemsValue >= GemItemsValue + item.Value)
            {
                var gemItems = GetGemItems();
                if(gemItems.Any(x => x.Key == item.Key))
                {
                    gemItems.Single(x => x.Key == item.Key).IncreasingValue(item.Value);
                }
                else
                {
                    this.bag.Add(item);
                }

                this.current += item.Value;
            }
        }

        private List<Item> GetGemItems()
        {
            return this.bag.Where(i => i is GemItem).ToList();
        }

        private List<Item> GetCashItems()
        {
            return this.bag.Where(i => i is CashItem).ToList();
        }

        private List<Item> GetGoldItems()
        {
            return this.bag.Where(i => i is GoldItem).ToList();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            var dictionary = this.bag.GroupBy(i => i.GetType().Name).ToDictionary(x => x.Key, x => x.ToList());

            foreach (var kvp in dictionary.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                if(kvp.Key == "CashItem")
                {
                    result.AppendLine($"<Cash> ${kvp.Value.Sum(x => x.Value)}");
                }
                else if(kvp.Key == "GemItem")
                {
                    result.AppendLine($"<Gem> ${kvp.Value.Sum(x => x.Value)}");
                }
                else if(kvp.Key == "GoldItem")
                {
                    result.AppendLine($"<Gold> ${kvp.Value.Sum(x => x.Value)}");
                }

                foreach (var item in kvp.Value.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
                {
                    result.AppendLine($"##{item.Key} - {item.Value}");
                }
            }

            return result.ToString().TrimEnd();
        }
    }
}
