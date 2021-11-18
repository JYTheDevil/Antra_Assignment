using System;

namespace Esxercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            double result = 0, a, b;

            Console.WriteLine("Enter the first number:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1.Addition\n" + 
                "2.Subtraction\n" + 
                "3.Multiplication\n" + 
                "4.Division\n" + 
                "5.Exit\n\n" + 
                "Enter number to Calculate:");
            option = Convert.ToInt32(Console.ReadLine());
            while (option != 5)
            {
                
                switch (option)
                {
                    case 1:
                        result = Arithmetic.Add(a,b);
                        break;

                    case 2:
                        result = Arithmetic.Subtract(a, b);
                        break;

                    case 3:
                        result = Arithmetic.Multiplication(a, b);
                        break;

                    case 4:
                        result = Arithmetic.Division(a, b);
                        break;
                }
                Console.WriteLine("\nThe result is: " +result + "\n");
                Console.WriteLine("1.Addition\n" +
                "2.Subtraction\n" +
                "3.Multiplication\n" +
                "4.Division\n" +
                "5.Exit\n\n" +
                "Enter number to Calculate:");
                option = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Thank you!");
        }
    }
}
