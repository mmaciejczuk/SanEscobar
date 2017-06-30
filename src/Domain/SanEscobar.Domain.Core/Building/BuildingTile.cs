﻿using System.Collections.Generic;

namespace SanEscobar.Domain.Core
{
    public abstract class BuildingTile
    {
        public int Cost { get; set; }

        public int VictoryPointValue { get; set; }

        public IList<bool> Occupation { get; set; }
    }
}