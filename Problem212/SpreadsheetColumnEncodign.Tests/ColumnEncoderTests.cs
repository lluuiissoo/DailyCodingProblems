using System;
using Xunit;
using SpreadsheetColumnEncoding;

namespace SpreadsheetColumnEncodign.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ColumnEncoder_Encode_GivenNumbersLowerThan26()
        {
            ColumnEncoder encoder = new ColumnEncoder();

            string result = encoder.Encode(1);
            string expectedResult = "A";

            Assert.Equal(result, expectedResult);

            result = encoder.Encode(2);
            expectedResult = "B";

            Assert.Equal(result, expectedResult);

            result = encoder.Encode(20);
            expectedResult = "T";

            Assert.Equal(result, expectedResult);

            result = encoder.Encode(26);
            expectedResult = "Z";

            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void ColumnEncoder_Encode_Given27_ReturnsAA()
        {
            ColumnEncoder encoder = new ColumnEncoder();

            string result = encoder.Encode(27);
            string expectedResult = "AA";

            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void ColumnEncoder_Encode_Given115_ReturnsDK()
        {
            ColumnEncoder encoder = new ColumnEncoder();

            string result = encoder.Encode(115);
            string expectedResult = "DK";

            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void ColumnEncoder_Encode_Given703_ReturnsAAA()
        {
            ColumnEncoder encoder = new ColumnEncoder();

            string result = encoder.Encode(703);
            string expectedResult = "AAA";

            Assert.Equal(result, expectedResult);
        }
    }
}
