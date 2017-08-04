using Microsoft.AspNetCore.Mvc;
using SanEscobar.Infrastructure.Services;
using SanEscobar.Infrastructure.DTO;

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

        [HttpGet("{Name}")]
        public PlayerDTO Get(string Name)
            => _playerService.Get(Name);
    }
}
