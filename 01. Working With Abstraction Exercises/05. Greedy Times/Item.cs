
namespace P05_GreedyTimes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Item
    {
        public string Key { get;  set; }
        public long Value { get;  set; }

        public void IncreasingValue(long value)
        {
            this.Value += value;
        }
    }
}
