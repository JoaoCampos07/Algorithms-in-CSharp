namespace HashTables
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class _1_OthersRomanDecoder
    {
        // First Solution
        private static readonly Dictionary<char, int> literals = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        public static int Decoder(string roman)
        {
            int result = 0;
            int max = 0;

            foreach (var c in roman.Reverse())
            {
                int value = literals[c];

                if (value < max) // i see if i subtract when I have a Less value char behind
                {
                    result -= value;
                }
                else
                {
                    result += value;
                    max = value;
                }
            }
            return result;
        }

        // Second solution
        public static int Decode2(string roman)
        {
            return roman
                .Replace("CM", "DCCCC") // Replace method is key here
                .Replace("CD", "CCCC")
                .Replace("XC", "LXXXX")
                .Replace("XL", "XXXX")
                .Replace("IX", "VIIII")
                .Replace("IV", "IIII")
                .Sum(c => Translate(c));
        }

        public static int Translate(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }
    }
}
