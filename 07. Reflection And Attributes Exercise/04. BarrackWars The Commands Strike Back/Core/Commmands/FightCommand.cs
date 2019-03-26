using System;
using System.Collections.Generic;
using System.Text;
using BarraksWars.Contracts;

namespace BarraksWars.Core.Commmands
{
    public class FightCommand : Command
    {
        public FightCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return string.Empty;
        }
    }
}
