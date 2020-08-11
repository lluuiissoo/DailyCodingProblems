using System;

namespace LongestConsecutive1InBinary
{
    public class NumberParser
    {
        public int GetLengthOfLongestSequence(int number)
        {
            string binaryRepresentation = GetBinaryRepresentation(number);

            int maxLength = 0, counter = 0;
            foreach (char c in binaryRepresentation)
            {
                if (c == '1')
                {
                    counter++;

                    if (counter > maxLength)
                        maxLength = counter;
                }
                else
                {
                    counter = 0; //Reset counter as current sequence ended
                }
            }

            return maxLength;
        }

        public string GetBinaryRepresentation(int number)
        {
            if (number == 0)
                return "0";
            else if (number == 1)
                return "1";
            else
            {
                int quotient = number / 2;
                int remainder = number % 2;

                return GetBinaryRepresentation(quotient) + GetBinaryRepresentation(remainder);
            }
        }
    }
}
