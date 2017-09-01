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
        private readonly ICommandDispatcher _commandDispatcher;

        public RedisController(ICommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }

        [HttpGet("{id?}")]
        public IActionResult Get(string id)
        {
            //var players = TempService.InitializePlayerDTO();
            //foreach(var player in players)
            //{
            //    RedisService.Add(player);
            //}

            var result = new object();

            if (id != null)
            {
                result = RedisService.Get<PlayerDTO>(id);
                if (result == null)
                {
                    return NotFound();
                }
                return new JsonResult(result);
            }

            else
            {
                result = RedisService.GetAll<PlayerDTO>();
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