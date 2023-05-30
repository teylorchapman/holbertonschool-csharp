using System;

///<summary>
/// Public Class
///</summary>
public class MatrixMath
{
    ///<summary>
    /// Method that rotates a square 2d matrix
    ///</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        angle *= -1;
        
        if (! ValidateMatrix2D(matrix))
            return new double[,] { {-1} };
        
        double[,] sum = new double[2, 2], rotate = new double[2,2] ;
        rotate[0, 0] =  Math.Cos(angle);
        rotate[0, 1] = -1 * Math.Sin(angle);
        rotate[1, 0] = Math.Sin(angle);
        rotate[1, 1] = Math.Cos(angle);
        
        sum = Multiply(matrix, rotate);
        for(int i = 0; i < sum.GetLength(0); i++)
        {
            for(int j = 0; j < sum.GetLength(1); j++)
            {
                sum[i, j] = Math.Round(sum[i, j], 2);
            }
        }
        return sum;
    }
}
