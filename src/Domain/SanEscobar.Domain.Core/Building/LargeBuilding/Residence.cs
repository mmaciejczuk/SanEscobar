using System.Linq;

namespace SanEscobar.Domain.Core2
{
    public class Residence : LargeBuildingTile
    {
        public override int CalculateEndGameBonus(PlayerBoard playerBoard)
        {
            if (Occupation.All(p => p != true))
                return 0;

            var plantationCount = playerBoard.IslandSpaces.Count(p => p != null);
            if (plantationCount > 9)
                switch (plantationCount)
                {
                    case 10:
                        return 5;
                    case 11:
                        return 6;
                    case 12:
                        return 7;
                    default:
                        return 0;
                }

            return 4;
        }
    }
}