using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            char[] array = str.ToCharArray(); //convert string to char array
            Array.Reverse(array); //using build in function to reverse array

            string reverse = new string(array); // convert array to string
            Console.WriteLine(reverse);
        }
    }
}
