using HashTables;
using System;
using Xunit;

namespace HashTableTests
{
    
    public class MyRomanDecoderTests
    {
        [Theory]
        [InlineData("IV", 4)]
        //[InlineData("MCMLIV", 1954)]
        //[InlineData("MCMXC", 1990)]
        //[InlineData("MMXIV", 2014)]
        public static void Test1(string roman, int expected)
        {
            var result = MyRomanDecoder.Decode(roman);

            Assert.Equal(expected, result);
        }
    }
}
