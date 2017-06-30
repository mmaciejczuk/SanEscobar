namespace SanEscobar.Domain.Core
{
    public abstract class LargeBuildingTile : BuildingTile
    {
        public abstract int CalculateEndGameBonus(PlayerBoard playerBoard);
    }
}
