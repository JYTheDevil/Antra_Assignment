using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, breadth, height;

            Console.WriteLine("How many boxes' volume you want to calculate: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i < count + 1; i++)
            {
                Console.WriteLine($"Enter the length for Box {i}: ");
                length = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the breadth for Box {i}: ");
                breadth = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the height for Box {i}: ");
                height = int.Parse(Console.ReadLine());

                Box box = new Box();

                box.setBreadth(breadth);
                box.setHeight(height);
                box.setLength(length);

                Console.WriteLine($"Volume of Box {i} : {box.getVolume()}\n");
            }
        }
    }
}
