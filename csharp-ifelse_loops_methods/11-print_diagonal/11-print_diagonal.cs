using System;

public class Line
{
    public static void PrintDiagonal(int length)
    {
        for (i = 0; i < length; i++)
        {
            for (j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
            Console.Write("\\");

        }
        Console.WriteLine();
    }
}
