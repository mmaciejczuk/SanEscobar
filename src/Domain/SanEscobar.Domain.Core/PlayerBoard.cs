using System.Collections.Generic;

namespace SanEscobar.Domain.Core2
{
    public class PlayerBoard
    {
        public Player Player { get; set; }

        public List<BuildingTile> CitySpaces { get; set; }

        public List<IslandTile> IslandSpaces { get; set; }

        public int Colonists { get; set; }

        public int Doubloons { get; set; }

        public List<GoodType> Goods { get; set; }

        public int VictoryPoints { get; set; }

        public PlayerBoard(Player player)
        {
            Player = player;
            CitySpaces = new List<BuildingTile>(12);
            IslandSpaces = new List<IslandTile>(12);
        }
    }
}