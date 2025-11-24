using System;

namespace MatrixOperations
{
    public static class MatrixProcessor
    {
        public static bool IsSquare(MatrixLibrary.Matrix matrix)
        {
            return matrix.Rows == matrix.Columns;
        }

        public static int CalculateDeterminant(MatrixLibrary.Matrix matrix)
        {
            if (!IsSquare(matrix))
            {
                Console.WriteLine("Ошибка: Определитель только для квадратных матриц.");
                return 0;
            }

            int n = matrix.Rows;

            if (n == 1) return matrix.GetValue(0, 0);

            if (n == 2)
            {
                return matrix.GetValue(0, 0) * matrix.GetValue(1, 1) - matrix.GetValue(0, 1) * matrix.GetValue(1, 0);
            }

            int determinant = 0;
            for (int j = 0; j < n; j++)
            {
                MatrixLibrary.Matrix subMatrix = new MatrixLibrary.Matrix(n - 1, n - 1);
                int subRow = 0;
                for (int row = 1; row < n; row++)
                {
                    int subCol = 0;
                    for (int col = 0; col < n; col++)
                    {
                        if (col == j) continue;
                        subMatrix.SetValue(subRow, subCol, matrix.GetValue(row, col));
                        subCol++;
                    }
                    subRow++;
                }

                int sign = (j % 2 == 0) ? 1 : -1;
                determinant += sign * matrix.GetValue(0, j) * CalculateDeterminant(subMatrix);
            }

            return determinant;
        }

        public static MatrixLibrary.Matrix MultiplyMatrices(MatrixLibrary.Matrix matrix1, MatrixLibrary.Matrix matrix2)
        {
            if (matrix1.Columns != matrix2.Rows)
            {
                Console.WriteLine("Ошибка умножения: Несовместимые матрицы.");
                return null;
            }

            int resultRows = matrix1.Rows;
            int resultCols = matrix2.Columns;
            MatrixLibrary.Matrix resultMatrix = new MatrixLibrary.Matrix(resultRows, resultCols);

            for (int i = 0; i < resultRows; i++)
            {
                for (int j = 0; j < resultCols; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrix1.Columns; k++)
                    {
                        sum += matrix1.GetValue(i, k) * matrix2.GetValue(k, j);
                    }
                    resultMatrix.SetValue(i, j, sum);
                }
            }
            return resultMatrix;
        }
    }
}
