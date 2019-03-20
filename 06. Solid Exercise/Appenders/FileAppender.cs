using LoggerExercise.Appenders.Contracts;
using LoggerExercise.Enums;
using LoggerExercise.Layouts.Contracts;
using LoggerExercise.Loggers.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LoggerExercise.Appenders
{
    public class FileAppender : Appender
    {
        private const string path = "../../../log.txt";
        private readonly ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile) 
            : base(layout)
        {
            this.logFile = logFile;
        }
               
        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if(reportLevel >= this.ReportLevel)
            {
                this.MessageCount++;
                string form = string.Format(this.Layout.Format, dateTime, reportLevel, message) + "\n";
                this.logFile.Write(form);

                File.AppendAllText(path, form);
            }
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, " +
               $"Report level: {this.ReportLevel.ToString().ToUpper()}, Messages appended: {this.MessageCount}, " +
               $"File size: {this.logFile.Size}";
        }
    }
}
