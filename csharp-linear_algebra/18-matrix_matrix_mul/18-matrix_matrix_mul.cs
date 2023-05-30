using System;

///<summary>
/// Public Class
///</summary>
public class MatrixMath
{
    ///<summary>
    /// Method that multiplies two matracies
    ///</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[,] { {-1} };
        
        double[,] sum = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int Row_A = 0; Row_A < matrix1.GetLength(0); Row_A++)
        {
            for (int Column_B = 0; Column_B < matrix2.GetLength(1); Column_B++)
            {
                for (int Column_A = 0; Column_A < matrix1.GetLength(1); Column_A++)
                {
                    sum[Row_A, Column_B] += matrix1[Row_A, Column_A] * matrix2[Column_A, Column_B];
                }
            }
        }
        return sum;
    }
}
