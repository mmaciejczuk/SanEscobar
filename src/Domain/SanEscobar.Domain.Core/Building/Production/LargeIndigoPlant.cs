using System.Collections.Generic;

namespace SanEscobar.Domain.Core
{
    public class LargeIndigoPlant : ProductionBuildingTile
    {
        public LargeIndigoPlant()
        {
            Cost = 3;
            VictoryPointValue = 2;
            GoodType = GoodType.Indigo;
            Occupation = new List<bool>(3);
        }
    }
}
