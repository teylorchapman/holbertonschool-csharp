using System;

public class Array
{
    public static void Reverse(int[] arr)
    {
        for (int i = arr.length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
