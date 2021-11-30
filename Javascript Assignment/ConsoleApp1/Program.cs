using System;

namespace ConsoleApp1
{
    class Class1
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3 };
            System.Console.WriteLine(peak(arr));
        }
        public static int peak(int[] arr)
        {
            int res = 0, up = 0, down = 0;
            for (int i = 1; i < arr.Length; ++i)
            {
                if (down > 0 && arr[i - 1] < arr[i] || arr[i - 1] == arr[i]) up = down = 0;
                if (arr[i - 1] < arr[i]) up++;
                if (arr[i - 1] > arr[i]) down++;
                if (up > 0 && down > 0 && up + down + 1 > res) res = up + down + 1;
            }
            return res;
        }
    }
}