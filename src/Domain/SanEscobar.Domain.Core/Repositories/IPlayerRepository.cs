using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanEscobar.Domain.Core2.Repositories
{
    public interface IPlayerRepository
    {
        Player Get(string id);
        Player GetByName(string Name);
        IEnumerable<Player> GetAll();
        void Add(Player player);
        void Remove(string id);
        void Update(Player player);
    }
}
