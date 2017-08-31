using Microsoft.AspNetCore.Mvc;
using SanEscobar.Infrastructure.Services;
using SanEscobar.Infrastructure.Commands.Players;
using System.Threading.Tasks;
using SanEscobar.Infrastructure.Commands;
using SanEscobar.Infrastructure.DTO;
using System;

namespace SanEscobar.Controllers
{
    [Route("api/redis")]
    public class RedisController : Controller
    {
        private readonly IRedisService _redisService;
        private readonly ICommandDispatcher _commandDispatcher;

        public RedisController(IRedisService redisService, ICommandDispatcher commandDispatcher)
        {
            _redisService = redisService;
            _commandDispatcher = commandDispatcher;
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            //var playerOne = new PlayerDTO()
            //{
            //    ConnectionId = "ConOne",
            //    Id = Guid.NewGuid().ToString(),
            //    PlayerName = "PlayerOne",
            //    IsPlaying = true
            //};

            //var playerTwo = new PlayerDTO()
            //{
            //    ConnectionId = "ConTwo",
            //    Id = Guid.NewGuid().ToString(),
            //    PlayerName = "PlayerTwo",
            //    IsPlaying = true
            //};

            RedisService redisService = new RedisService();
            //var playerOneId = redisService.Add(playerOne);
            //var playerTwoId = redisService.Add(playerTwo);

            var result = new object();

            if (id != null)
            {
                result = redisService.Get<PlayerDTO>(id);
                if (result == null)
                {
                    return NotFound();
                }
                return new JsonResult(result);
            }

            else
            {
                result = redisService.GetAll<PlayerDTO>();
                if (result == null)
                {
                    return NotFound();
                }
                return new JsonResult(result);
            }                     
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreatePlayer command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return Created($"players/{command.Name}", new object());
        }
    }
}