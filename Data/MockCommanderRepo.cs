using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
  public class MockCommanderRepo : ICommanderRepo
  {
    public IEnumerable<Command> GetAllCommands()
    {
      var commands = new List<Command>{
        new Command{Id=0,HowTo="Boil an egg",Line="Boil water",Platform="Kettle & Pan"},
        new Command{Id=0,HowTo="Fry an egg",Line="Put the oil",Platform="Pan"},
        new Command{Id=0,HowTo="Cut Bread",Line="Soften the bread",Platform="Chopping bread"}

      };
      return commands;
    }

    public Command GetCommandById(int id)
    {
      return new Command { Id = id, HowTo = "Boil an egg", Line = "  Boil water", Platform = "Kettle & Pan" };

    }
  }
}