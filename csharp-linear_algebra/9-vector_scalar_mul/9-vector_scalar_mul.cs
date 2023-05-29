using System;

///<summary>
/// Public Class
///</summary>
public class VectorMath
{
    ///<summary>
    /// Method that multiplies a vector and a scalar
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length != 3 && vector.Length != 2)
        {
            return(new Double[1]{-1});
        }

        double[] sum = new double[vector.Length];
        for (int x = 0; i < vector.Length; x++)
        {
            sum[x] = vector[x] * scalar;
        }
        return sum;
    }
}
