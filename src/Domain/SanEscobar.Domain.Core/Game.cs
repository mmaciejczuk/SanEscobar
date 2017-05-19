using System.Collections.Generic;

namespace SanEscobar.Domain.Core
{
    public class Game
    {
        private Queue<Player> _players;

        public Queue<Player> Players
        {
            get { return _players; }
        }

        public Game(List<Player> players)
        {
            var noOfPlayers = players.Count;

            InitializePlayerList(noOfPlayers);
        }

        private void InitializePlayerList(int noOfPlayers)
        {
            _players = new Queue<Player>(noOfPlayers);
        }
    }
}
