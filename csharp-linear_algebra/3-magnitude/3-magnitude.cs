using System;

///<summary>
/// Public class
///</summary>
public class VectorMath
{
    ///<summary>
    /// Method to calculate & return the length of a vector
    ///</summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 3 || vector.Length != 2)
        {
            return (-1);
        }

        double sum = 0;
        foreach (double x in vector)
        {
            sum += x * x;
        }
        return Math.Round(Math.Sqrt(sum), 2);
    }
}
