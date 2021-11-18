using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int i, j;
            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = rows - 1; i >= 1; i--)
            {
                for (j = 1; j <= rows - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
