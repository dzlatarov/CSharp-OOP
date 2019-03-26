using BarraksWars.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BarraksWars.Core.Commmands
{
    public class InterpredCommand : ICommandInterpreter
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public InterpredCommand(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }
        

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type commandType = assembly.GetTypes().First(t => t.Name.ToLower() == commandName + "command");

            IExecutable command = (IExecutable)Activator.CreateInstance(commandType, new object[] { data, this.repository, this.unitFactory });

            return command;
        }
    }
}
