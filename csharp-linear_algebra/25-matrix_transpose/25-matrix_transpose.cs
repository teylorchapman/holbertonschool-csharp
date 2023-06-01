using System;
using System.Collections;

///<summary>
/// Public class
///</summary>
public class MatrixMath
{
    ///<summary> Prototype </summary>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0)
        {
            return new double[,] {};
        }

        double[,] transposeMatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                transposeMatrix[column, row] = Math.Round(matrix[row, column], 2);
            }
        }
    }
}
