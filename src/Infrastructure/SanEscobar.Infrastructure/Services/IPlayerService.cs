using SanEscobar.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanEscobar.Infrastructure.Services
{
    public interface IPlayerService
    {
        PlayerDTO Get(string Id);
        void Register(string ConnectionId, string Name, string Group);
    }
}
