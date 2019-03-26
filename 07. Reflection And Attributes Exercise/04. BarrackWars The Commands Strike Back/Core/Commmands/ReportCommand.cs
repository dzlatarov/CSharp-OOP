using System;
using System.Collections.Generic;
using System.Text;
using BarraksWars.Contracts;

namespace BarraksWars.Core.Commmands
{
    public class ReportCommand : Command
    {
        public ReportCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string output = this.Repository.Statistics;
            return output;
        }
    }
}
