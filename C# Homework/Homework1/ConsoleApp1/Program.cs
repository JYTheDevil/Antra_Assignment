using System;

class CAssignment
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3 };
        outputArray(arr);
    }

    public static void outputArray(int[] arr){
        int j = 0;
        int[] res = new int [arr.Length*2];
        for (int i = 0; i < res.Length; i++)
        {
            
            res[i] = arr[j];
            Console.Write(res[i]+" ");
            j++;

            if (j == arr.Length)
            {
                j = 0;
            }
        }

    }
}
