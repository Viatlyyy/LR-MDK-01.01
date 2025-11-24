using System;

namespace MatrixLibrary
{
    public class Matrix
    {
        public int[,] data;
        public int Rows;
        public int Columns;

        public Matrix(int rows, int columns)
        {
            if (rows <= 0) rows = 1;
            if (columns <= 0) columns = 1;

            this.Rows = rows;
            this.Columns = columns;
            data = new int[rows, columns];
        }

        public void SetValue(int row, int col, int value)
        {
            if (row >= 0 && row < Rows && col >= 0 && col < Columns)
            {
                data[row, col] = value;
            }
            else
            {
                Console.WriteLine($"Ошибка установки: Индекс ({row},{col}) вне границ.");
            }
        }

        public int GetValue(int row, int col)
        {
            if (row >= 0 && row < Rows && col >= 0 && col < Columns)
            {
                return data[row, col];
            }
            Console.WriteLine($"Ошибка получения: Индекс ({row},{col}) вне границ.");
            return 0;
        }

        public override string ToString()
        {
            string matrixString = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    matrixString += data[i, j].ToString().PadLeft(5) + " ";
                }
                matrixString += Environment.NewLine;
            }
            return matrixString;
        }
    }
}
