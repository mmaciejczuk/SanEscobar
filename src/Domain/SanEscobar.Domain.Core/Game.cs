using System.Collections.Generic;
using SanEscobar.Domain.Core.Extensions;

namespace SanEscobar.Domain.Core
{
    public class Game
    {
        public Queue<Player> Players { get; private set; }

        public Game(List<Player> players)
        {
            InitializePlayerList(players);
        }

        private void InitializePlayerList(List<Player> players)
        {
            var noOfPlayers = players.Count;
            Players = new Queue<Player>(noOfPlayers);
            players.Randomize();

            foreach (var player in players)
            {
                Players.Enqueue(player);
            }
        }
    }
}
