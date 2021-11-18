using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter trhe Number of Rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            int last = 0;

            for (int i = 1; i <= rows; i++)
            {
                for (int r = 1; r <= i; r++)
                {
                    if (last == 1)
                    {
                        Console.Write("0");
                        last = 0;
                    }
                    else if (last == 0)
                    {
                        Console.Write("1");
                        last = 1;
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
