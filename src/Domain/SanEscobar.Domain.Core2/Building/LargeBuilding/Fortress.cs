using System.Linq;

namespace SanEscobar.Domain.Core2
{
    public class Fortress : LargeBuildingTile
    {
        public override int CalculateEndGameBonus(PlayerBoard playerBoard)
        {
            if (Occupation.All(p => p != true))
                return 0;

            var colonistsOnBuildingTilesCount = playerBoard.CitySpaces.Sum(p => p.Occupation.Count(c => c));
            var colonistsOnIslandTilesCount = playerBoard.IslandSpaces.Count(p => p.Occupied);
            var totalColonistsCount = colonistsOnIslandTilesCount + colonistsOnBuildingTilesCount +
                                      playerBoard.Colonists;

            return totalColonistsCount % 3;
        }
    }
}