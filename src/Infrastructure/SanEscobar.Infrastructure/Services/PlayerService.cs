using SanEscobar.Domain.Core;
using SanEscobar.Domain.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using SanEscobar.Infrastructure.DTO;
using AutoMapper;

namespace SanEscobar.Infrastructure.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;

        public PlayerService(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }

        public PlayerDTO Get(string Name)
        {
            var player = _playerRepository.GetByName(Name);
            return _mapper.Map<Player, PlayerDTO>(player);
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

