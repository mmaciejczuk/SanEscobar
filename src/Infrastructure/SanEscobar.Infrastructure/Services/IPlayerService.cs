using SanEscobar.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SanEscobar.Infrastructure.Services
{
    public interface IPlayerService
    {
        Task<PlayerDTO> GetAsync(string Id);
        Task RegisterAsync(string ConnectionId, string Name, string Group);
    }
}
