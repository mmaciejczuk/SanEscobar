using System;

namespace SanEscobar.Domain.Core2
{
    public class Player
    {
        public string ConnectionId { get; protected set; }

        public string Id { get; protected set; }

        public string Name { get; protected set; }

        public string Hash { get; protected set; }

        public string Group { get; protected set; }

        public bool IsPlaying { get; protected set; }

        protected Player()
        {
        }

        protected Player(string connectionId, string name, string group)
        {
            ConnectionId = connectionId;
            Id = Guid.NewGuid().ToString();
            Name = name;
            Hash = Guid.NewGuid().ToString("N");
            Group = group;
            IsPlaying = true;
        }

        public static Player Create(string connectionId, string name, string group)
            => new Player(connectionId, name, group);
    }
}
