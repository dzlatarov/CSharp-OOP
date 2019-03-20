using LoggerExercise.Appenders.Contracts;
using LoggerExercise.Appenders.Factory.Contracts;
using LoggerExercise.Layouts.Contracts;
using LoggerExercise.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerExercise.Appenders.Factory
{
    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            var typeAsLower = type.ToLower();

            switch(typeAsLower)
            {
                case "consoleappender":
                    return new ConsoleAppender(layout);
                case "fileappender":
                    return new FileAppender(layout, new LogFile());

                default:
                    throw new ArgumentException("Invalid type!");
            }
        }
    }
}
