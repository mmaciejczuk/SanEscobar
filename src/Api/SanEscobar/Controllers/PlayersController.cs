using Microsoft.AspNetCore.Mvc;
using SanEscobar.Infrastructure.Services;
using SanEscobar.Infrastructure.DTO;
using SanEscobar.Infrastructure.Commands.Players;
using System.Threading.Tasks;

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
        public async Task<PlayerDTO> Get(string name)
            => await _playerService.GetAsync(name);

        [HttpPost]
        public async Task Post([FromBody]CreatePlayer request)
            => await _playerService.RegisterAsync(request.ConnectionId, request.Name, request.Group);
    }
}