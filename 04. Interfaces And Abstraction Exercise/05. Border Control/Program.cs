
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
            var identity = new List<IIdentity>();


            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                var borderControl = input.Split();


                if (borderControl.Length == 3)
                {
                    Citizen citizen = new Citizen(borderControl[0], int.Parse(borderControl[1]), borderControl[2]);
                    identity.Add(citizen);
                }
                else if (borderControl.Length == 2)
                {
                    Robot robot = new Robot(borderControl[0], borderControl[1]);
                    identity.Add(robot);
                }
            }

            string fakeId = Console.ReadLine();

            identity
                .Select(x => x.Id)
                .Where(x => x.EndsWith(fakeId))
                .ToList()
                .ForEach(Console.WriteLine);            
        }
    }
}
