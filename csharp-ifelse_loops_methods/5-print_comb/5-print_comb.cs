using System;

public class hexed
{
    public static void Main(string[] args)
    {
        for (int i = 0; i <= 99; i++)
        {
            if (i < 99)
                Console.Write($"{i.ToString("D2")}, ");
            else
                Console.Write($"{i.ToString("D2")}\n");
        }
    }
}
