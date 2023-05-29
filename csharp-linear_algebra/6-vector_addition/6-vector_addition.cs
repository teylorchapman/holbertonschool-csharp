using System;

///<summary>
/// Public Class
///</summary>
public class VectorMath
{
    ///<summary>
    /// Method that adds two vectors
    ///</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length ||
        vector1.Length != 3 && vector1.Length != 2 ||
        vector2.Length != 3 && vector2.Length != 2)
        {
            return (new Double[1]{-1});
        }

        double[] sum = new Double[vector1.Length];
        for (int x = 0; x < vector1.Length; x++)
        {
            sum[x] = vector1[x] + vector2[x];
        }
        return sum;
    }
}
