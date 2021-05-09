namespace HashTableTests
{
    using HashTables;

    using System;
    using System.Collections.Generic;
    using System.Text;

    using Xunit;

    public class _1_MyRomanDecoderTests
    {
        [Theory]
        [InlineData("IV", 4)]
        //[InlineData("MCMLIV", 1954)]
        //[InlineData("MCMXC", 1990)]
        //[InlineData("MMXIV", 2014)]
        public static void Test1(string roman, int expected)
        {
            var result = _1_MyRomanDecoder.Decode(roman);

            Assert.Equal(expected, result);
        }
    }
}
