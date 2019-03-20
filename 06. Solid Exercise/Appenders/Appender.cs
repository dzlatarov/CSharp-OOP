using LoggerExercise.Appenders.Contracts;
using LoggerExercise.Enums;
using LoggerExercise.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerExercise.Appenders
{
    public abstract class Appender : IAppender
    {
        private readonly ILayout layout;

        public Appender(ILayout layout)
        {
            this.layout = layout;
        }

        protected ILayout Layout => this.layout;

        public int MessageCount { get; protected set; }

        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);        
    }
}
