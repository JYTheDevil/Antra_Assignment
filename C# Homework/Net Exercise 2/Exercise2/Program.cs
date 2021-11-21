using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("\nEnter numbers into array: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Solution solution = new Solution();
            int result = solution.solution(array);
            Console.WriteLine($"The most often value is: {result}");
        }
    }
}
