namespace Arrays.RLZeros
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Solution
    {
        public static void MoveZeroes_Basic(int[] arr)
        {
            // TODO: Program me
            // 1. Do one pass and discover here are the zeros 
            //      1.1 Loop, keep the indexs in HashTable or List 
            // 2. Them we need to do RL until the zero be at the initial position 
            //      2.1 RL : Loop throught, exchange value 0 in position X with value in position X-1. And continue
            //               until we reach the beginning of the array
            //      2.2 This would be nested loops
            //PROBLEM : I have the positions of the zeros in a HashTable
            //          But when I going to pass the zeros to the end after the first iteration they are all wrong

            // 1. Loop throught the elements
            // 2. ...Until we find a zero, them we need to pass the zero to the end.
            // 3. 
            var counter = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    var indx = i;
                    for (int j = indx; j < arr.Length - counter; j++)
                    {
                        var aux = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = aux;
                    }
                    counter++;
                }
            }
        }

        public static void MoveZeroes_Intermediate(int[] arr)
        {
            var result = arr
                .Select((num, index) => new { Position = index, Value = num })
                .OrderBy(a => a.Value == 0)
                .Select(x => x.Value)
                .ToArray();
        }

        public static void MoveZeroes_Advanced(int[] arr)
            => arr.OrderBy(x => x == 0).ToArray();
    }
}
