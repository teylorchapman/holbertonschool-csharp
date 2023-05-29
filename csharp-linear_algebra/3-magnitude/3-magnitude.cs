using System;

///<summary>
/// Public class
///</summary>
public class VectorMath
{
    ///<summary>
    /// Method for calculating the length of the vector
    /// it also will return the length
    ///</summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 3 && vector.Length != 2)
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
