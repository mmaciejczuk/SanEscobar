namespace SanEscobar.Domain.Core
{
    public class Player
    {
        public string ConnectionId { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Hash { get; set; }

        public string Group { get; set; }

        public bool IsPlaying { get; set; }
    }
}
