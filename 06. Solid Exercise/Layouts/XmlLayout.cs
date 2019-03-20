using LoggerExercise.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerExercise.Layouts
{
    public class XmlLayout : ILayout
    {
        public string Format
        {
            get
            {
                var sb = new StringBuilder();
                sb.AppendLine("<log>");
                sb.AppendLine("   <date>{0}</date>");
                sb.AppendLine("   <level>{1}</level>");
                sb.AppendLine("   <message>{2}</message>");
                sb.AppendLine("</log>");

                return sb.ToString();
            }
        }
    }
}
