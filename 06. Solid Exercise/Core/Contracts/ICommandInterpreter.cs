using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerExercise.Core.Contracts
{
    public interface ICommandInterpreter
    {
        void AddAppender(string[] args);

        void addReport(string[] args);

        void PrintInfo();
    }
}
