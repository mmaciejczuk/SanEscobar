using SanEscobar.Domain.Core;
using SanEscobar.Domain.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using SanEscobar.Infrastructure.DTO;

namespace SanEscobar.Infrastructure.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public PlayerDTO Get(string Name)
        {
            var player = _playerRepository.GetByName(Name);
            return new PlayerDTO
            {
                ConnectionId = player.ConnectionId,
                Id = player.Id,
                Name = player.Name,
                IsPlaying = player.IsPlaying
            };
        }

        public void Register(string ConnectionId, string Name, string Group)
        {
            var player = _playerRepository.GetByName(Name);  
            if(player == null)
            {
                throw new Exception($"Player with name: '{0}' already exists.");
            }

            player = Player.Create(ConnectionId, Name, Group);
            _playerRepository.Add(player);
        }
    }
}

