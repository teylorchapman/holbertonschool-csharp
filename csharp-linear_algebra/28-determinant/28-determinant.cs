using System;

///<summary>
/// Public class
///</summary>
public class MatrixMath
{
    ///<summary> Method to calculate the determinant of a matrix </summary>
    public static double Determinant(double[,] matrix)
    {
        double determinantM = 0;

        if (2 == matrix.GetLength(0) && 2 == matrix.GetLength(1))
        {
            determinantM = Math.Round((matrix[0, 0]*matrix[1, 1] - matrix[0, 1]*matrix[1, 0]), 2);
        }
        else if (3 == matrix.GetLength(0) && 3 == matrix.GetLength(1))
        {
            determinantM = Math.Round(
                (
                    matrix[0, 0]*matrix[1, 1]*matrix[2, 2] + 
                    matrix[0, 1]*matrix[1, 2]*matrix[2, 0] +
                    matrix[0, 2]*matrix[1, 0]*matrix[2, 1]
                ) -
                (
                    matrix[0, 0]*matrix[1, 2]*matrix[2, 1] +
                    matrix[0, 1]*matrix[1, 0]*matrix[2, 2] +
                    matrix[0, 2]*matrix[1, 1]*matrix[2, 0]
                ), 2);
        } else { return -1; }
        
        return determinantM;
    }
}
