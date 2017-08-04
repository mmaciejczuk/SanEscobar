using SanEscobar.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedisCache
{
    public interface IPlayerService
    {
        string AddPlayer(string gameId, Player player);
        Player GetPlayer(string playerId);
        bool DeletePlayer(string playerId);
    }
}
