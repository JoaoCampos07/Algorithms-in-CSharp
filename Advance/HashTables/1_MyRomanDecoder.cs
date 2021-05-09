namespace HashTables
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class _1_MyRomanDecoder
    {
        public static Dictionary<char, int> romanNumerals = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        public static Dictionary<string, int> romanNumeralsSub = new Dictionary<string, int>
        {
            // relation between numbers/ pattern in numbers
            {"IV", 2}, // VI => 6 and XI => 4 ==> 2
            {"IX", 4}, // IX => 9 and XI => 11 --- 2
            {"CM", 200}, // CM => 900 or MC => 1100 --- 200 
            {"XC", 20}, // CX = 100 + 10 opposite XC => 90 -- 20
            //{'', 100},
            //{'D', 500},
            //{'M', 1000},
        };

        public static int Decode(string roman)
        {
            // 1 loop
            var decodedWihtouSub = roman.Select(digit => romanNumerals[digit]).Sum();

            // 2 discover what to subtract
            //var arry = roman.ToCharArray();
            int toSubtract = 0;
            for (int i = 0; i < roman.Length - 1; i++)
            {
                var strx = roman[i].ToString() + roman[i + 1].ToString(); // TODO : put together two charcters in stirng
                if (romanNumeralsSub.TryGetValue(strx, out int value))
                {
                    toSubtract += value;
                }
            }

            return decodedWihtouSub - toSubtract;
        }
    }
}
