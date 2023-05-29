using System;

///<summary>
/// Public class
///</summary>
public class MatrixMath
{
    ///<summary>
    /// Method that adds two matrices
    ///</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(0) > 3 || matrix1.GetLength(0) < 2 || matrix1.Length != matrix2.Length)
            return new double[,] { {-1} };

        if (matrix2.GetLength(0) > 3 || matrix2.GetLength(0) < 2)
            return new double[,] { {-1} };
        
        double[,] sum = new double[matrix1.GetLength(0), matrix1.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0): i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrix1[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return matrix1;
    }
}
