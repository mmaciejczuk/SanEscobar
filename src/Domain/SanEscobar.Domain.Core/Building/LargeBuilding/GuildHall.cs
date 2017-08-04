using System.Linq;

namespace SanEscobar.Domain.Core
{
    public class GuildHall : LargeBuildingTile
    {
        public override int CalculateEndGameBonus(PlayerBoard playerBoard)
        {
            if (Occupation.All(p => p != true))
                return 0;

            var smallProductionBuildingBonus =
                playerBoard.CitySpaces.Count(p => p is SmallIndigoPlant || p is SmallSugarMill);
            var largeProductionBuildingBonus =
                playerBoard.CitySpaces.Count(
                    p => p is LargeIndigoPlant || p is LargeSugarMill || p is TobaccoStorage || p is CoffeeRoaster) * 2;

            return smallProductionBuildingBonus + largeProductionBuildingBonus;
        }
    }
}