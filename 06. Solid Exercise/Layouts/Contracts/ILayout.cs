using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerExercise.Layouts.Contracts
{
    public interface ILayout
    {
        string Format { get; }
    }
}
