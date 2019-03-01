using System;

namespace StudentSystemCatalog
{
    public class Startup
    {
        public static void Main()
        {
            StudentSystem studentSystem = new StudentSystem();
            while (true)
            {
                var commands = Console.ReadLine();
                studentSystem.ParseCommand(commands);

                if(commands == "Exit")
                {
                    break;
                }
            }
        }
    }
}
