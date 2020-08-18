using System;
using System.Collections.Generic;

namespace SevenishNumber
{
    public class SevenishNumber
    {
        public int GetNumber(int nPosition)
        {
            double result = 0;

            double sum = 0;

            int power = 0;
            
            for (int i=0; i<nPosition; i++)
            {
                if ((i == 0) || (i%2==1))
                {
                    result = Math.Pow(7,power++);
                    sum += result;
                }
                else
                {
                    result = sum;
                }
            }

            return  Convert.ToInt32(result);
        }
    }
}
