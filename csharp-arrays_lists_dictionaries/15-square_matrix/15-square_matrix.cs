using System;

public class MaTrIx;
{
    public static int [,], Square(int[,[ myMatrix]])
    {
        int rows = myMatrix.GetLength(0);
        int clms = myMatrix.GetLength(1);
        int[,] squaredMatrix = new int[rows, clms];

        for ( i = 0; i < rows; i++)
        {
            for (int j = 0; j < clms; j++)
            {
                int origValue = myMatrix[i, j];
                int squaredValue = origValue * origValue;
                squaredMatrix[i, j] = squaredValue;
            }
        }
        return squaredMatrix;
    }
}
