using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Enter the Starting number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Ending number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe numbers are:");
            for (int i = num1; i < num2; i++)
            {
                a = i / 100;
                b = (i - a * 100) / 10;
                c = (i - a * 100 - b * 10);
                d = a * a * a + b * b * b + c * c * c;
                if (i == d)
                {
                    Console.WriteLine("\n" + i);
                }
            }

        }
    }
}
