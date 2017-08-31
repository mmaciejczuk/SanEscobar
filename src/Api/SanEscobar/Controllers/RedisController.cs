using Microsoft.AspNetCore.Mvc;
using SanEscobar.Infrastructure.Services;
using SanEscobar.Infrastructure.Commands.Players;
using System.Threading.Tasks;
using SanEscobar.Infrastructure.Commands;
using SanEscobar.Infrastructure.DTO;

namespace SanEscobar.Controllers
{
    [Route("[controller]")]
    public class RedisController : Controller
    {
        private readonly IRedisService _redisService;
        private readonly ICommandDispatcher _commandDispatcher;

        public RedisController(IRedisService redisService, ICommandDispatcher commandDispatcher)
        {
            _redisService = redisService;
            _commandDispatcher = commandDispatcher;
        }

        [HttpGet("{name}")]
        public ActionResult Get(string id)
        {

            var player = _redisService.GetObject<PlayerDTO>(id);
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