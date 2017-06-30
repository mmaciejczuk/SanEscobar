using System;

namespace SanEscobar.Domain.Core
{
    public class CargoShip
    {
        public GoodType? GoodType { get; private set; }

        public int Capacity { get; }

        public int Quantity { get; private set; }

        public int AvailableCapacity => Capacity - Quantity;

        public CargoShip(int capacity)
        {
            Capacity = capacity;
            Quantity = 0;
        }

        public void AddQuantityToShip(GoodType goodType, int quantity)
        {
            if (GoodType.HasValue && GoodType != goodType)
            {
                string message = $"Cannot add goods different than those already present on the ship ({GoodType.Value}).";
                throw new ArgumentException(message);
            }

            GoodType = goodType;

            if (quantity + Quantity > Capacity)
            {
                string message = $"Quantity of goods cannot exceed the ship's current capacity ({AvailableCapacity} available).";
                throw new Exception(message);
            }

            Quantity += quantity;
        }

        public void Clear()
        {
            Quantity = 0;
        }
    }
}