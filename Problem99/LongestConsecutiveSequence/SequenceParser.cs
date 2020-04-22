using System;
using System.Collections;
using System.Collections.Generic;

namespace LongestConsecutiveSequence
{
    public class SequenceParser
    {
        public int[] Collection { get; private set;}

        public SequenceParser(int[] arr)
        {
            this.Collection = arr;
        }

        public int GetLongestSequenceLength()
        {
            int maxLength = 0;
            //A hash table containing the elements found in the collection along with the occurrence, where the key is the element itself, and the value is the number of sequential elements before and after, so far
            //Current Value = 1 + (Value of Previous Element) + (Value of Next Element)
            Dictionary<int,int> dictionary = new Dictionary<int, int>();
                        
            for (int i = 0; i < this.Collection.Length; i++)
            {
                int element = this.Collection[i];
                if (!dictionary.ContainsKey(element)) //Ignore duplicate elements
                {
                    int prevCount = (dictionary.ContainsKey(element-1)) ? dictionary[element-1] : 0;
                    int nextCount = (dictionary.ContainsKey(element+1)) ? dictionary[element+1] : 0;
                    int selfCount = 1 + prevCount + nextCount;

                    dictionary.Add(element, selfCount);
                    
                    if (selfCount > maxLength)
                        maxLength = selfCount;
                }
            }

            return maxLength;
        }
    }
}
