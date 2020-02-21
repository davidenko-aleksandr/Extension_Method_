using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Method
{
    public static class Helper
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }

        public static Road CreateRandomRoad(this Road road, int min, int max)
        {
            var rnd = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
            road.Number = "E" + rnd.Next(1, 100);
            road.Lenght = rnd.Next(min, max);
            return road;
        }
    }
}
