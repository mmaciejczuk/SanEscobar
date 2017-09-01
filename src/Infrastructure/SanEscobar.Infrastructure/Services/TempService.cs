using SanEscobar.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanEscobar.Infrastructure.Services
{
    public static class TempService
    {
        public static IList<PlayerDTO> InitializePlayerDTO()
        {
            return new List<PlayerDTO>
            {
                new PlayerDTO
                {
                    ConnectionId = "ConOne",
                    Id = Guid.NewGuid().ToString(),
                    PlayerName = "PlayerOne",
                    IsPlaying = true
                },
                new PlayerDTO
                {
                    ConnectionId = "ConOne",
                    Id = Guid.NewGuid().ToString(),
                    PlayerName = "PlayerOne",
                    IsPlaying = true
                },
            };
        }
    }
}
