using Microsoft.AspNetCore.Mvc;
using SanEscobar.Infrastructure.Services;
using SanEscobar.Infrastructure.DTO;
using SanEscobar.Infrastructure.Commands.Players;

namespace SanEscobar.Controllers
{
    [Route("[controller]")]
    public class PlayersController : Controller
    {
        private readonly IPlayerService _playerService;
        public PlayersController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet("{name}")]
        public PlayerDTO Get(string name)
            => _playerService.Get(name);

        [HttpPost("")]
        public void Post([FromBody]CreatePlayer request)
        {
            _playerService.Register(request.ConnectionId, request.Name, request.Group);
        }
    }
}
