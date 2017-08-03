using System.Collections.Generic;

namespace SanEscobar.Domain.Core2
{
    public class SmallIndigoPlant : ProductionBuildingTile
    {
        public SmallIndigoPlant()
        {
            Cost = 1;
            VictoryPointValue = 1;
            GoodType = GoodType.Indigo;
            Occupation = new List<bool>(1);
        }
    }
}
