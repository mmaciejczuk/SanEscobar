using SanEscobar.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanEscobar.Infrastructure.Services
{
    public interface IRedisService
    {
        string AddPlayer(string gameName, Player player);
        Player GetPlayer(string playerId);
        bool DeletePlayer(string playerId);
    }
}
