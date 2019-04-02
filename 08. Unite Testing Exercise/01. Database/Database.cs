using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_Database
{
    public class Database
    {
        private const int Capacity = 16;

        private int[] array;
        private int index;

        public Database(params int[] values)
        {
            this.CheckArrayLegth(values);
            this.array = new int[16];
            this.index = 0;
            this.FillArray(values);
        }

        private void CheckArrayLegth(int[] values)
        {
            if (values.Length > 16)
            {
                throw new InvalidOperationException("Legth cannot be more than 16!");
            }
        }

        private void FillArray(int[] values)
        {
            foreach (var value in values)
            {
                this.Add(value);
            }
        }

        public void Add(int value)
        {
            if (this.index == Capacity)
            {
                throw new InvalidOperationException("Array is full!");
            }

            this.array[this.index] = value;
            this.index++;
        }

        public void Remove()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("Array is empty!");
            }

            this.array[this.index] = 0;
            this.index--;
        }

        public int[] Fetch()
        {
            return this.array.Take(this.index).ToArray();
        }
    }
}
