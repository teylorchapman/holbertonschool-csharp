using System;

public class Int
{
    public static void Divide(int a, int b)
    {
        try
        {
            int sum = a / b;
        }
        catch (Exception)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, sum)
        }
    }
}
