using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
  [Route("api/commands")]
  [ApiController]
  public class CommandsController : ControllerBase
  {
    private readonly ICommanderRepo _repository;

    public CommandsController(ICommanderRepo repository)
    {
      _repository = repository;
    }


    //private readonly MockCommanderRepo _repository = new MockCommanderRepo();
    //GET api/commands
    [HttpGet]
    public ActionResult<IEnumerable<Command>> GetAllCommands()
    {
      var commandItems = _repository.GetAllCommands();
      return Ok(commandItems);
    }
    //GET api/commands/{id}
    [HttpGet("{id}")]
    public ActionResult<CommandsController> GetCommandById(int id)
    {
      var commandItem = _repository.GetCommandById(id);
      return Ok(commandItem);

    }
  }
}