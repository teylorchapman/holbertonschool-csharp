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
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        if (rows != columns)
            return new double[,] { {-1} };
        
        double[,] rotatedMatrix = new double[rows, columns];
        double cosAngle = Math.Cos(angle);
        double sinAngle = Math.Sin(angle);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                double x = i - (rows - 1) / 2.0;
                double y = j - (columns - 1) / 2.0;

                double rotatedX = x * cosAngle - y * sinAngle;
                double rotatedY = x * sinAngle + y * cosAngle;

                rotatedX += (rows - 1) / 2.0;
                rotatedY += (columns - 1) / 2.0;

                rotatedMatrix[i, j] = Math.Round(matrix[(int)rotatedX, (int)rotatedY]);
            }
        }
        return rotatedMatrix;
    }
}
