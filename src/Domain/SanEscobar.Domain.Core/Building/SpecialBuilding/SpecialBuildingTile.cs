namespace SanEscobar.Domain.Core.Building
{
    public abstract class SpecialBuildingTile : BuildingTile
    {
        public RoleType RoleType { get; set; }

        //public abstract void BuildingCheckBeforeAction();

        //public abstract void BuildingCheckAfterAction();

        //public abstract void BuildingCheckAtEnd();
    }
}
