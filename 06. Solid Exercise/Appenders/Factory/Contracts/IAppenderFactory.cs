using LoggerExercise.Appenders.Contracts;
using LoggerExercise.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerExercise.Appenders.Factory.Contracts
{
    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout);
    }
}
