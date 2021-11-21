using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Solution
    {
        public int solution(int a, int b)
        {
            while (a>b)
            {
                Console.WriteLine("A must be greater than B, please try again! ");
                Console.WriteLine("A: ");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("b: ");
                b = int.Parse(Console.ReadLine());
            }

            double c = Math.Sqrt(a);
            double d = Math.Sqrt(b);

            a = (int)Math.Floor(c);
            b = (int)Math.Floor(d);
            
            return  b - a +1;
        }

    }
}
