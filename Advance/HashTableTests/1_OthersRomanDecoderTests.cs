namespace HashTableTests
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Xunit;

    public class _1_OthersRomanDecoderTests
    {
        [Theory]
        [InlineData("IV", 4)]
        [InlineData("MCMLIV", 1954)]
        [InlineData("MCMXC", 1990)]
        [InlineData("MMXIV", 2014)]
        public static void Test1(string roman, int expected)
        {
            var result = HashTables._1_OthersRomanDecoder.Decoder(roman);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("IV", 4)]
        [InlineData("MCMLIV", 1954)]
        [InlineData("MCMXC", 1990)]
        [InlineData("MMXIV", 2014)]
        public static void Test2(string roman, int expected)
        {
            var result = HashTables._1_OthersRomanDecoder.Decode2(roman);

            Assert.Equal(expected, result);
        }
    }
}
