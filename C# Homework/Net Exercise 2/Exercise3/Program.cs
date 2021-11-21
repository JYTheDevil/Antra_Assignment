using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enther the second number: ");
            int b = int.Parse(Console.ReadLine());

            Solution solution = new Solution();
            int c = solution.solution(a, b);
            Console.WriteLine("\n"+ c);
        }
    }
}
