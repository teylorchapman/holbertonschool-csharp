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
        
        if (matrix is double[,] && matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
            return new double[,] { {-1} };
        
        double[,] sum = new double[2, 2], rotate = new double[2,2] ;
        rotate[0, 0] =  Math.Cos(angle);
        rotate[0, 1] = -1 * Math.Sin(angle);
        rotate[1, 0] = Math.Sin(angle);
        rotate[1, 1] = Math.Cos(angle);
        
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        double[,] results = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                double sum = 0;
                for (int k = 0; k < 2; k++)
                {
                    sum += matrix[i, k] * rotate[k, j];
                }
                results[i, j] = sum;
            }
        }

        double[,] results = new double(matrix, rotate);
        for(int i = 0; i < results.GetLength(0); i++)
        {
            for(int j = 0; j < results.GetLength(1); j++)
            {
                results[i, j] = Math.Round(results[i, j], 2);
            }
        }
        return results;
    }
}
