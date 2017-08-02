using SanEscobar.Domain.Core2.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanEscobar.Infrastructure.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        
        public void CreatePlayer(string Name, string Group, string ConnectionId, bool IsPlaying)
        {

        }
    }
}
