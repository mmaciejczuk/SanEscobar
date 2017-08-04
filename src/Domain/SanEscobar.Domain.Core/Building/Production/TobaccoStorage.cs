using System.Collections.Generic;

namespace SanEscobar.Domain.Core
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
