using LoggerExercise.Appenders.Contracts;
using LoggerExercise.Enums;
using LoggerExercise.Loggers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerExercise.Loggers
{
    public class Logger : ILogger
    {
        private readonly IAppender consoleAppender;
        private readonly IAppender fileAppender;

        public Logger(IAppender consoleAppender)
        {
            this.consoleAppender = consoleAppender;
        }
        
        public Logger(IAppender consoleAppender, IAppender fileAppender)
            : this(consoleAppender)
        {
            this.fileAppender = fileAppender;
        }

        public void Error(string dateTime, string errorMessage)
        {
            this.AppendMessages(dateTime, ReportLevel.ERROR, errorMessage);
        }        

        public void Info(string dateTime, string infoMessage)
        {
            this.AppendMessages(dateTime, ReportLevel.INFO, infoMessage);
        }

        public void Fatal(string dateTime, string fatalMessage)
        {
            this.AppendMessages(dateTime, ReportLevel.FATAL, fatalMessage);
        }

        public void Warning(string dateTime, string warningMessage)
        {
            this.AppendMessages(dateTime, ReportLevel.WARNING, warningMessage);
        }

        public void Critical(string dateTime, string criticalMessage)
        {
            this.AppendMessages(dateTime, ReportLevel.CRITICAL, criticalMessage);
        }

        private void AppendMessages(string dateTime, ReportLevel reportLevel, string message)
        {
            this.consoleAppender?.Append(dateTime, reportLevel, message);
            this.fileAppender?.Append(dateTime, reportLevel, message);
        }
    }
}
