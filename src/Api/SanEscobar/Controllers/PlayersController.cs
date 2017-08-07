using Microsoft.AspNetCore.Mvc;
using SanEscobar.Infrastructure.Services;
using SanEscobar.Infrastructure.DTO;
using SanEscobar.Infrastructure.Commands.Players;
using System.Threading.Tasks;
using SanEscobar.Infrastructure.Commands;

namespace SanEscobar.Controllers
{
    [Route("[controller]")]
    public class PlayersController : Controller
    {
        private readonly IPlayerService _playerService;
        private readonly ICommandDispatcher _commandDispatcher;

        public PlayersController(IPlayerService playerService, ICommandDispatcher commandDispatcher)
        {
            _playerService = playerService;
            _commandDispatcher = commandDispatcher;
        }

        [HttpGet("{name}")]
        public async Task<ActionResult> Get(string name)
        {
            var player = await _playerService.GetAsync(name);
            if (User == null)
            {
                return NotFound();
            }

            return Json(player);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody]CreatePlayer command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Created($"players/{command.Name}", new object());
        }
    }
}