using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanEscobar.Domain.Core.Repositories
{
    public interface IPlayerRepository
    {
        Task<Player> GetAsync(string id);
        Task<Player> GetByNameAsync(string Name);
        Task<IEnumerable<Player>> GetAllAsync();
        Task AddAsync(Player player);
        Task RemoveAsync(string id);
        Task UpdateAsync(Player player);
    }
}