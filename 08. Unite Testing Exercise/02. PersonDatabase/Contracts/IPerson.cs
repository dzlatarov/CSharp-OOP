using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Database.Contracts
{
    public interface IPerson
    {
        long Id { get; }

        string Username { get; }
    }
}
