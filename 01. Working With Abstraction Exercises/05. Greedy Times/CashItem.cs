
namespace P05_GreedyTimes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CashItem : Item
    {
        public CashItem(string key, long value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
