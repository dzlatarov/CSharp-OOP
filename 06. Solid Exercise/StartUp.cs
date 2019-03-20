using LoggerExercise.Appenders;
using LoggerExercise.Appenders.Contracts;
using LoggerExercise.Core;
using LoggerExercise.Core.Contracts;
using LoggerExercise.Enums;
using LoggerExercise.Layouts;
using LoggerExercise.Layouts.Contracts;
using LoggerExercise.Loggers;
using LoggerExercise.Loggers.Contracts;
using System;

namespace LoggerExercise
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            Engine engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
