using System.Collections.Generic;

namespace SanEscobar.Domain.Core2
{
    public class CoffeeRoaster : ProductionBuildingTile
    {
        public CoffeeRoaster()
        {
            Cost = 6;
            VictoryPointValue = 3;
            GoodType = GoodType.Coffee;
            Occupation = new List<bool>(2);
        }
    }
}
