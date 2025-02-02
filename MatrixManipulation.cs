using System;

public class MatrixOperations
{
    private static Random random = new Random();

    // Method to create a random matrix taking rows and columns as parameters
    public static int[,] CreateRandomMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 10); // Random numbers between 1 and 9
            }
        }
        return matrix;
    }

    // Method to add two matrices
    public static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }
        return result;
    }

    // Method to subtract two matrices
    public static int[,] SubtractMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrixA[i, j] - matrixB[i, j];
            }
        }
        return result;
    }

    // Method to multiply two matrices
    public static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int colsB = matrixB.GetLength(1);
        int[,] result = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                for (int k = 0; k < colsA; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return result;
    }

    // Method to find the transpose of a matrix
    public static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transpose = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }
        return transpose;
    }

    // Method to find the determinant of a 2x2 matrix
    public static int Determinant2x2(int[,] matrix)
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    // Method to find the determinant of a 3x3 matrix
    public static int Determinant3x3(int[,] matrix)
    {
        return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
             - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
             + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    }

    // Method to find the inverse of a 2x2 matrix
    public static double[,] Inverse2x2(int[,] matrix)
    {
        int determinant = Determinant2x2(matrix);
        if (determinant == 0) throw new InvalidOperationException("Matrix is not invertible.");

        double[,] inverse = new double[2, 2];
        inverse[0, 0] = matrix[1, 1] / (double)determinant;
        inverse[0, 1] = -matrix[0, 1] / (double)determinant;
        inverse[1, 0] = -matrix[1, 0] / (double)determinant;
        inverse[1, 1] = matrix[0, 0] / (double)determinant;
        return inverse;
    }

    // Method to find the inverse of a 3x3 matrix
    public static double[,] Inverse3x3(int[,] matrix)
    {
        int determinant = Determinant3x3(matrix);
        if (determinant == 0) throw new InvalidOperationException("Matrix is not invertible.");

        double[,] inverse = new double[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int[,] minor = GetMinor(matrix, i, j);
                inverse[j, i] = (Determinant2x2(minor) * ((i + j) % 2 == 0 ? 1 : -1)) / (double)determinant;
            }
        }
        return inverse;
    }

    // Helper method to get the minor matrix for a 3x3 matrix
    private static int[,] GetMinor(int[,] matrix, int row, int col)
    {
        int[,] minor = new int[2, 2];
        int mRow = 0, mCol = 0;
        for (int i = 0; i < 3; i++)
        {
            if (i == row) continue;
            mCol = 0;
            for (int j = 0; j < 3; j++)
            {
                if (j == col) continue;
                minor[mRow, mCol++] = matrix[i, j];
            }
            mRow++;
        }
        return minor;
    }

    // Method to display a matrix
    public static void DisplayMatrix<T>(T[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        // Example usage
        int[,] matrixA = CreateRandomMatrix(3, 3);
        int[,] matrixB = CreateRandomMatrix(3, 3);

        Console.WriteLine("Matrix A:");
        DisplayMatrix(matrixA);

        Console.WriteLine("Matrix B:");
        DisplayMatrix(matrixB);

        Console.WriteLine("Addition of A and B:");
        DisplayMatrix(AddMatrices(matrixA, matrixB));

        Console.WriteLine("Subtraction of A and B:");
        DisplayMatrix(SubtractMatrices(matrixA, matrixB));

        Console.WriteLine("Multiplication of A and B:");
        DisplayMatrix(MultiplyMatrices(matrixA, matrixB));

        Console.WriteLine("Transpose of A:");
        DisplayMatrix(TransposeMatrix(matrixA));

        Console.WriteLine("Determinant of A:");
        Console.WriteLine(Determinant3x3(matrixA));

        try
        {
            Console.WriteLine("Inverse of A:");
            DisplayMatrix(Inverse3x3(matrixA));
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}