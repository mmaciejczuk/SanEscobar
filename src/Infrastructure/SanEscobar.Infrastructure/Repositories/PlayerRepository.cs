using System;
using System.Collections.Generic;
using System.Text;
using SanEscobar.Domain.Core;
using SanEscobar.Domain.Core.Repositories;
using System.Linq;
using SanEscobar.Infrastructure.Services;
using System.Threading.Tasks;

namespace SanEscobar.Infrastructure.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly ISanEscobarContext _db;

        public PlayerRepository()
        {

        }

        public PlayerRepository(ISanEscobarContext db)
        {
            _db = db;
        }

        public async Task<Player> GetAsync(string id)
            => await Task.FromResult(_db.Players.SingleOrDefault(x => x.Id == id.ToString()));

        public async Task<IEnumerable<Player>> GetAllAsync()
            => await Task.FromResult(_db.Players);

        public async Task AddAsync(Player player)
        {
            _db.Players.Add(player);
            await Task.CompletedTask;
        }

        public async Task<Player> GetByNameAsync(string Name)
            => await Task.FromResult(_db.Players.SingleOrDefault(x => x.Name == Name));

        public async Task RemoveAsync(string id)
        {
            var player = await GetAsync(id);
            _db.Players.Remove(player);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(Player player)
        {
            await Task.CompletedTask;
        }
    }
}