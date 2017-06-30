using System.Collections.Generic;
using System.Linq;
using SanEscobar.Domain.Core.Building;

namespace SanEscobar.Domain.Core
{
    public class CityHall : LargeBuildingTile
    {
        public CityHall()
        {
            Cost = 10;
            VictoryPointValue = 4;
            Occupation = new List<bool>(1);
        }

        public override int CalculateEndGameBonus(PlayerBoard playerBoard)
        {
            if (Occupation.All(p => p != true))
                return 0;

            return playerBoard.CitySpaces.Count(p => p is SpecialBuildingTile || p is LargeBuildingTile);
        }
    }
}