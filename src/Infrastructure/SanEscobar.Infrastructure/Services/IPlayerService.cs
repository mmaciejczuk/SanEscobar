using System;
using System.Collections.Generic;
using System.Text;

namespace SanEscobar.Infrastructure.Services
{
    public interface IPlayerService
    {
        void CreatePlayer(string Name, string Group, string ConnectionId, bool IsPlaying);
    }

}
