using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Solution
    {
        public int solution (int [] a)
        {
            Array.Sort(a);
            int curr = 0, max = 0, result = 0;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == a[i - 1]) 
                {
                    curr++;
                }
                else
                {
                    if (curr > max)
                    {
                        max = curr;
                        result = a[i - 1];
                    }
                    curr = 1;
                }
            }
            return result;
        }
    }
}
