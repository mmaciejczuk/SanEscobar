using System;
using System.Collections.Generic;
using System.Text;

namespace SanEscobar.Infrastructure.DTO
{
    public class PlayerDTO
    {
        public string ConnectionId { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Hash { get; set; }

        public string Group { get; set; }

        public bool IsPlaying { get; set; }
    }
}
