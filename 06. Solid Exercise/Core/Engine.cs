using LoggerExercise.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerExercise.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            var appendersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < appendersCount; i++)
            {
                var appenderArgs = Console.ReadLine()
                    .Split();

                this.commandInterpreter.AddAppender(appenderArgs);
            }

            var line = Console.ReadLine();

            while(line != "END")
            {
                var reportArgs = line
                    .Split("|");

                this.commandInterpreter.addReport(reportArgs);

                line = Console.ReadLine();
            }

            this.commandInterpreter.PrintInfo();
        }
    }
}
