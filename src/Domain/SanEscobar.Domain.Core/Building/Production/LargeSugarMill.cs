using System.Collections.Generic;

namespace SanEscobar.Domain.Core
{
    public class LargeSugarMill : ProductionBuildingTile
    {
        public LargeSugarMill()
        {
            Cost = 4;
            VictoryPointValue = 2;
            GoodType = GoodType.Sugar;
            Occupation = new List<bool>(3);
        }
    }
}
