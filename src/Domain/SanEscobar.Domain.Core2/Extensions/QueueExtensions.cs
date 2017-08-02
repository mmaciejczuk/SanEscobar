using System;
using System.Collections.Generic;

namespace SanEscobar.Domain.Core2.Extensions
{
    internal static class QueueExtensions
    {
        private static readonly Random Random = new Random();

        public static void Randomize<T>(this IList<T> list)
        {
            var n = list.Count;

            while (n > 1)
            {
                n--;
                var k = Random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}