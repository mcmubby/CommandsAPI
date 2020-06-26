using Command.Services;
using Microsoft.AspNetCore.Mvc;

namespace Command.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandService _repo;

        public CommandsController(ICommandService repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public ActionResult GetAllCommands()
        {
            var allc = _repo.GetAllCommands();
            return Ok(allc);
        }
    }
}