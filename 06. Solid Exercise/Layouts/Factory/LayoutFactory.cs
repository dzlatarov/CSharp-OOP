using LoggerExercise.Layouts.Contracts;
using LoggerExercise.Layouts.Factory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerExercise.Layouts.Factory
{
    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            var typeAsLower = type.ToLower();

            switch(typeAsLower)
            {
                case "simplelayout":
                    return new SimpleLayout();
                case "xmllayout":
                    return new XmlLayout();                    

                default:
                    throw new ArgumentException("Invalid type!");
            }
        }
    }
}
