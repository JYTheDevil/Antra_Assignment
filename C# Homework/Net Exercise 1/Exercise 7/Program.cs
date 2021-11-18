using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 1000, change = 0;
            int option = 0,  pin =0;

            Console.WriteLine("Enter Your Pin Number");
            pin = Convert.ToInt32(Console.ReadLine());

            while (pin != 123)
            {
                Console.WriteLine("You Entered invalid PIN, please try again: ");
                pin = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("\n*****Welcome to ATM Service******\n"+"1.Check Balance\n" +
                "2.Withdraw Cash\n" +
                "3.Deposit Cash\n" +
                "4.Quit\n" +
                "******************\n" +
                "Enter your choice:");
            option = Convert.ToInt32(Console.ReadLine());
            while (option != 4)
            {

                switch (option)
                {
                    case 1:
                        Console.WriteLine($"YOU'RE BALANCE IN Rs: {amount}");
                        break;

                    case 2:
                        Console.WriteLine("Enter the amount you want to withdraw: ");
                        change = Convert.ToDouble(Console.ReadLine());
                        while(amount - change < 0)
                        {
                            Console.WriteLine("You don't have enough amount in your account, please try again");
                            change = Convert.ToDouble(Console.ReadLine());
                        }
                        amount = amount - change;
                        Console.WriteLine($"You withdraw  {change} sucessfully! The remaining amount is: {amount}");
                        break;

                    case 3:
                        Console.WriteLine("Enter the amount you want to deposit: ");
                        change = Convert.ToDouble(Console.ReadLine());

                        amount = amount + change;
                        Console.WriteLine($"You deposited  {change} sucessfully! The remaining amount is: {amount}");
                        break;

                    default:
                        Console.WriteLine("Please enter number between 1-4 ");
                        break;
                }
                Console.WriteLine("\n*****Welcome to ATM Service******\n" + "1.Check Balance\n" +
               "2.Withdraw Cash\n" +
               "3.Deposit Cash\n" +
               "4.Quit\n" +
               "******************\n" +
               "Enter your choice:");
                option = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Thank you!");
        }
    }
}
