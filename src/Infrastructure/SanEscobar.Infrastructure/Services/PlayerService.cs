using SanEscobar.Domain.Core;
using SanEscobar.Domain.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using SanEscobar.Infrastructure.DTO;
using AutoMapper;
using System.Threading.Tasks;

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

        public async Task<PlayerDTO> GetAsync(string name)
        {
            var player = await _playerRepository.GetByNameAsync(name);
            return _mapper.Map<Player, PlayerDTO>(player);
        }

        public async Task RegisterAsync(string connectionId, string name, string group)
        {
            var player = await _playerRepository.GetByNameAsync(name);  
            if(player == null)
            {
                throw new Exception($"Player with name: '{0}' already exists.");
            }

            player = Player.Create(connectionId, name, group);
            await _playerRepository.AddAsync(player);
        }
    }
}

