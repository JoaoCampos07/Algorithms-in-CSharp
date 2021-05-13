namespace LinkedLists.MultiplesThreeAndFive
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Solution
    {
        private static int GetMultiplesTotal_Master(int value)
          => Enumerable.Range(0, value)
              .Where(value => value % 3 == 0 || value % 5 == 0)
              .Sum();

        private static int GetMultiplesTotal_Advance(int value)
            => value > 0 ? Enumerable.Range(0, value)
                                .Aggregate(0, (total, next) => next % 3 == 0 || next % 5 == 0 ? total += next : total) : 0;

        private static int GetMultiplesTotal_Basic(int value)
        {
            int total = 0;
            for (int i = value - 1; i >= 0; i--)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }
            return total;
        }
    }
}
