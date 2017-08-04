using System;
using System.Collections.Generic;
using System.Text;
using SanEscobar.Domain.Core;
using SanEscobar.Domain.Core.Repositories;
using System.Linq;
using SanEscobar.Infrastructure.Services;

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
                
        public void Add(Player player)
            => _db.Players.Add(player);

        public Player Get(string id)
            => _db.Players.Single(x => x.Id == id.ToString());

        public IEnumerable<Player> GetAll()
            => _db.Players;

        public Player GetByName(string Name)
            => _db.Players.Single(x => x.Name == Name);

        public void Remove(string id)
        {
            var player = Get(id);
            _db.Players.Remove(player);
        }

        public void Update(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
