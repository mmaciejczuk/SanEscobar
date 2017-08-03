using System;
using System.Collections.Generic;

namespace SanEscobar.Domain.Core2
{
    public class TradingHouse
    {
        public List<GoodType?> Goods { get; private set; }

        public TradingHouse()
        {
            Goods = new List<GoodType?>(4);
        }

        public int AddGoodToTradingHouse(GoodType goodToAdd, bool allowTradingOfSameGoods)
        {
            if (!allowTradingOfSameGoods && Goods.Contains(goodToAdd))
            {
                string message = $"Cannot add goods same as those already present in the trading house ({goodToAdd}).";
                throw new ArgumentException(message);
            }

            for (var i = 0; i < Goods.Count; i++)
            {
                if (!Goods[i].HasValue)
                {
                    Goods[i] = goodToAdd;
                }
            }

            return (int)goodToAdd;
        }

        public void Clear()
        {
            Goods = new List<GoodType?>();
        }
    }
}