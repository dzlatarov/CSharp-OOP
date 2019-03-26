using System;
using System.Collections.Generic;
using System.Text;
using BarraksWars.Contracts;

namespace BarraksWars.Core.Commmands
{
    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = this.Data[1];

            try
            {
                this.Repository.RemoveUnit(unitType);
                return $"{unitType} retired!";
            }
            catch(ArgumentException ex)
            {
                return ex.Message;
            }
        }
    }
}
