using System;

namespace SanEscobar.Domain.Core2
{
    public class Player
    {
        public string ConnectionId { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Hash { get; set; }

        public string Group { get; set; }

        public bool IsPlaying { get; set; }

        public Player()
        {

        }

        public Player(string connectionId, string name, string group)
        {
            ConnectionId = connectionId;
            Id = Guid.NewGuid().ToString();
            Name = name;
            Hash = Guid.NewGuid().ToString("N");
            Group = group;
            IsPlaying = true;
        }
    }
}
