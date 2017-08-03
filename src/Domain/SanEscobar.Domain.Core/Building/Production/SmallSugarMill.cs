using System.Collections.Generic;

namespace SanEscobar.Domain.Core2
{
    public class SmallSugarMill : ProductionBuildingTile
    {
        public SmallSugarMill()
        {
            Cost = 2;
            VictoryPointValue = 1;
            GoodType = GoodType.Sugar;
            Occupation = new List<bool>(1);
        }
    }
}
