using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_Database
{
    public class Database
    {
        private const int Capacity = 16;

        private Person[] data;
        private int index;

        public Database(params Person[] data)
        {
            this.CheckArrayLegth(data);
            this.data = new Person[16];
            this.index = 0;
            this.FillArray(data);
        }

        private void CheckArrayLegth(Person[] data)
        {
            if (data.Length > 16)
            {
                throw new InvalidOperationException("Length cannot be more than 16!");
            }
        }

        private void FillArray(Person[] data)
        {
            foreach (var person in data)
            {
                this.Add(person);
            }
        }

        public void Add(Person person)
        {
            if (this.index == Capacity)
            {
                throw new InvalidOperationException("Array is full!");
            }

            if(this.data.Any(p => p != null && p.Username == person.Username))
            {
                throw new InvalidOperationException("This username is already taken!");
            }

            if(this.data.Any(p => p != null && p.Id == person.Id))
            {
                throw new InvalidOperationException("This id is already taken!");
            }

            this.data[this.index] = person;
            this.index++;
        }

        public void Remove()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("Array is empty!");
            }


            this.data[this.index] = null;
            this.index--;
        }

        public Person FindByUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("Username cannot be null or empty!");
            }

            if (!this.data.Any(p => p != null && p.Username == username))
            {
                throw new InvalidOperationException("Person with this username doesn't exist!");
            }            

            return this.data.First(p => p != null && p.Username == username);
        }

        public Person FindById(long id)
        {
            if (id < 0)
            {
                throw new ArgumentException("Id cannot be negative!");
            }

            if (!this.data.Any(p => p != null && p.Id == id))
            {
                throw new InvalidOperationException("Person with this id doesn't exist!");
            }
           
            return this.data.First(p => p != null && p.Id == id);
        }

        public Person[] Fetch()
        {
            return this.data.Take(this.index).ToArray();
        }
    }
}
