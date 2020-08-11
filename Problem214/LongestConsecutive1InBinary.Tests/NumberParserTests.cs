using System;
using Xunit;
using LongestConsecutive1InBinary;

namespace LongestConsecutive1InBinary.Tests
{
    public class NumberParserTests
    {
        [Fact]
        public void GetLengthOfLongestSequence_Given_156_ShouldReturn_3()
        {
            NumberParser parser = new NumberParser();

            int input = 156;
            int result = parser.GetLengthOfLongestSequence(input);
            int expected = 3;

            Assert.Equal(result,expected);           
        }

        [Fact]
        public void GetLengthOfLongestSequence_Given_908_ShouldReturn_3()
        {
            NumberParser parser = new NumberParser();

            int input = 908;
            int result = parser.GetLengthOfLongestSequence(input);
            int expected = 3;

            Assert.Equal(result,expected);           
        }

        [Fact]
        public void GetBinaryRepresentation_Given_Intergers_ShouldReturn_BinaryRepresentation()
        {
            NumberParser parser = new NumberParser();

            int input = 0;
            string result = parser.GetBinaryRepresentation(input);
            string expected = "0";

            Assert.Equal(result,expected);

            input = 1;
            result = parser.GetBinaryRepresentation(input);
            expected = "1";

            Assert.Equal(result,expected);

            input = 2;
            result = parser.GetBinaryRepresentation(input);
            expected = "10";

            Assert.Equal(result,expected);

            input = 5;
            result = parser.GetBinaryRepresentation(input);
            expected = "101";

            Assert.Equal(result,expected);

            input = 10;
            result = parser.GetBinaryRepresentation(input);
            expected = "1010";

            input = 908;
            result = parser.GetBinaryRepresentation(input);
            expected = "1110001100";

            Assert.Equal(result,expected);
        }
    }
}
