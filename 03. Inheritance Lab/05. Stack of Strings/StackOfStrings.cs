
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
    public class StackOfStrings : List<string>
    {
        public void Push(string item)
        {
            this.Add(item);
        }

        public string Pop()
        {
            string element = this.Last();
            this.RemoveAt(this.Count - 1);

            return element;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            return this.Last();
        }

        public bool IsEmpty()
        {
            return this.Count == 0;
        }
    }
}
