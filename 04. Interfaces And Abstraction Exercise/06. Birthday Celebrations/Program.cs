
namespace BorderControl
{
    using BorderControl.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var identity = new List<IBirthdate>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                var borderControl = input.Split();


                if (borderControl[0] == "Citizen")
                {                    
                    identity.Add(new Citizen(borderControl[1], int.Parse(borderControl[2]), borderControl[3], borderControl[4]));
                }
                
                else if(borderControl[0] == "Pet")
                {                                    
                    identity.Add(new Pet(borderControl[1], borderControl[2]));
                }
            }

            string yearToSearch = Console.ReadLine();

            identity
                .Select(x => x.Birthdate)
                .Where(x => x.EndsWith(yearToSearch))
                .ToList()
                .ForEach(Console.WriteLine);            
        }
    }
}
