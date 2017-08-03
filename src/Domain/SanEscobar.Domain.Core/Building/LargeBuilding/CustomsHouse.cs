using System.Linq;

namespace SanEscobar.Domain.Core2
{
    public class CustomsHouse : LargeBuildingTile
    {
        public override int CalculateEndGameBonus(PlayerBoard playerBoard)
        {
            if (Occupation.All(p => p != true))
                return 0;

            return playerBoard.VictoryPoints % 4;
        }
    }
}