using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanEscobar.Domain.Core.Repositories
{
    public interface IPlayerRepository
    {
        Player Get(Guid id);
        IEnumerable<Player> GetAll();
        void Add(Player player);
        void Update(Player player);
    }
}
