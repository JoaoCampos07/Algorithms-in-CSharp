using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var example = new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };

            var example2 = new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };

            MoveZeros.MoveZeroes_Intermediate(example2);

            MoveZeros.MoveZeroes_Basic(example);
        }
    }
}
