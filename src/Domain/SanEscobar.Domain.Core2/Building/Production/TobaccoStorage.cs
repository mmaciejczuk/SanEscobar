using System.Collections.Generic;

namespace SanEscobar.Domain.Core2
{
    public class TobaccoStorage : ProductionBuildingTile
    {
        public TobaccoStorage()
        {
            Cost = 5;
            VictoryPointValue = 3;
            GoodType = GoodType.Tobacco;
            Occupation = new List<bool>(3);
        }
    }
}
