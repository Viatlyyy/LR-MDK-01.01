using System;

using MatrixLibrary;
using MatrixOperations;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Демонстрация работы с матрицами ---");
            Console.WriteLine();

            Matrix matrixA = new Matrix(3, 3);
            matrixA.SetValue(0, 0, 1); matrixA.SetValue(0, 1, 2); matrixA.SetValue(0, 2, 3);
            matrixA.SetValue(1, 0, 4); matrixA.SetValue(1, 1, 5); matrixA.SetValue(1, 2, 6);
            matrixA.SetValue(2, 0, 7); matrixA.SetValue(2, 1, 8); matrixA.SetValue(2, 2, 9);
            Console.WriteLine("Матрица A:");
            Console.WriteLine(matrixA.ToString());

            Console.WriteLine($"Значение A[1, 1]: {matrixA.GetValue(1, 1)}");
            Console.WriteLine($"A квадратная? {MatrixProcessor.IsSquare(matrixA)}");
            Console.WriteLine($"Определитель A: {MatrixProcessor.CalculateDeterminant(matrixA)}");
            Console.WriteLine();

            Matrix matrixB = new Matrix(2, 2);
            matrixB.SetValue(0, 0, 5); matrixB.SetValue(0, 1, 2);
            matrixB.SetValue(1, 0, 3); matrixB.SetValue(1, 1, 4);
            Console.WriteLine("Матрица B:");
            Console.WriteLine(matrixB.ToString());
            Console.WriteLine($"B квадратная? {MatrixProcessor.IsSquare(matrixB)}");
            Console.WriteLine($"Определитель B: {MatrixProcessor.CalculateDeterminant(matrixB)}");
            Console.WriteLine();

            Console.WriteLine("Умножаем A * B...");
            Matrix resultAB = MatrixProcessor.MultiplyMatrices(matrixA, matrixB);
            if (resultAB != null)
            {
                Console.WriteLine("Результат A * B:");
                Console.WriteLine(resultAB.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("Пытаемся умножить A (3x3) на C (2x3)...");
            Matrix matrixC = new Matrix(2, 3);
            Matrix resultAC = MatrixProcessor.MultiplyMatrices(matrixA, matrixC);
            if (resultAC == null)
            {
                Console.WriteLine("Умножение не удалось, как и ожидалось.");
            }

            Console.WriteLine("\n--- Конец демонстрации ---");
            Console.ReadKey();
        }
    }
}