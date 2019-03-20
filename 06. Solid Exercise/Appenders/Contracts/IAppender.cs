using LoggerExercise.Enums;
using LoggerExercise.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerExercise.Appenders.Contracts
{
    public interface IAppender
    {        
        int MessageCount { get; }

        ReportLevel ReportLevel { get; set; }

        void Append(string dateTime, ReportLevel reportLevel, string message);
    }
}
