using System;
using Xunit;
using SevenishNumber;

namespace SevenishNumber.Tests
{
    public class SevenishNumberTests
    {
        [Fact]
        public void SevenishNumber_GetNumber_GivenFirstPosition()
        {
            SevenishNumber sNumber = new SevenishNumber();
            int expected = 1;
            int actual = sNumber.GetNumber(1);

            Assert.Equal(expected,actual);
        }

        [Fact]
        public void SevenishNumber_GetNumber_GivenOddPosition()
        {
            SevenishNumber sNumber = new SevenishNumber();
            int expected = 57;
            int actual = sNumber.GetNumber(5);
            //1,7,8,49,57,343,400

            Assert.Equal(expected,actual);
        }

        [Fact]
        public void SevenishNumber_GetNumber_GivenEvenPosition()
        {
            SevenishNumber sNumber = new SevenishNumber();
            int expected = 343;
            int actual = sNumber.GetNumber(6);
            //1,7,8,49,57,343,400

            Assert.Equal(expected,actual);
        }
    }
}
