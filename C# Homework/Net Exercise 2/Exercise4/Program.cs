using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Solution solution = new Solution();

            foreach (var p in solution.SpiralOrder(array))
            {
                Console.Write(p + " ");
            }
        }


    }
}
