using P01_Database.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Database
{
    public class Person : IPerson
    {
        public Person(string username, long id)
        {
            this.Username = username;
            this.Id = id;
        }

        public long Id { get; private set; }

        public string Username { get; private set; }
    }
}
