namespace SanEscobar.Domain.Core2
{
    public abstract class LargeBuildingTile : BuildingTile
    {
        public abstract int CalculateEndGameBonus(PlayerBoard playerBoard);
    }
}
