using System;

public class hexed
{
    public static void Main(string[] args)
    {
        for (int i = 0; i <=8; i++)
        {
            for (int j = i + 1; j <= 9; j++)
            {
                if (i < 8)
                    Console.Write($"{i}{j}, ");
                else
                    Console.Write($"{i}{j}\n");
            }
        }
    }
}
