
using Xunit;
using LongestConsecutiveSequence;

namespace LongestConsecutiveSequence.Tests
{
    public class SequenceParserTests
    {
        [Fact]
        public void SequenceParser_ForArray_ShouldReturn4()
        {
            //Arrange
            int[] arr = new int[] {100, 4, 200, 1, 3, 2};
            SequenceParser seq = new SequenceParser(arr);
            int expected = 4; //{1,2,3,4}

            //Act
            int len = seq.GetLongestSequenceLength();

            //Assert
            Assert.Equal(expected, len);
        }

        [Fact]
        public void SequenceParser_ForArray_ShouldReturn3()
        {
            //Arrange
            int[] arr = new int[] {100, 4, 200, 101, 3, 102};
            SequenceParser seq = new SequenceParser(arr);
            int expected = 3; //{100,101,102}

            //Act
            int len = seq.GetLongestSequenceLength();

            //Assert
            Assert.Equal(expected, len);
        }

        [Fact]
        public void SequenceParser_ForArrayWithDuplicates_ShouldReturn3()
        {
            //Arrange
            int[] arr = new int[] {100, 4, 200, 101, 3, 4, 102};
            SequenceParser seq = new SequenceParser(arr);
            int expected = 3; //{100,101,102}

            //Act
            int len = seq.GetLongestSequenceLength();

            //Assert
            Assert.Equal(expected, len);
        }

        [Fact]
        public void SequenceParser_ForReverseArray_ShouldReturnArrayLength()
        {
            //Arrange
            int[] arr = new int[] {100, 99, 98, 97, 96, 95, 94};
            SequenceParser seq = new SequenceParser(arr);
            int expected = 7; //{94,95,96,97,98,99,100}

            //Act
            int len = seq.GetLongestSequenceLength();

            //Assert
            Assert.Equal(expected, len);
        }
    }
}
