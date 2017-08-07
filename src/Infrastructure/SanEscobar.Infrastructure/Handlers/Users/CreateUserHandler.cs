using SanEscobar.Infrastructure.Commands;
using SanEscobar.Infrastructure.Commands.Players;
using SanEscobar.Infrastructure.Services;
using System;
using System.Threading.Tasks;

namespace SanEscobar.Infrastructure.Handlers.Users
{
    public class CreateUserHandler : ICommandHandler<CreatePlayer>
    {
        private readonly IPlayerService _playerService;

        public CreateUserHandler(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public async Task HandleAsync(CreatePlayer command)
        {
            await _playerService.RegisterAsync(command.ConnectionId, command.Name, command.Group);
        }
    }
}
