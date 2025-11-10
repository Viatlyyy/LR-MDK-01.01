using System;

namespace Task_1_var_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите количество чисел в массиве: ");
            string inputN = Console.ReadLine();
            n = int.Parse(inputN);

            double[] numbers = new double[n];

            Console.WriteLine("Введите числа, разделяя их пробелами:");
            string inputNumbers = Console.ReadLine();
            string[] parts = inputNumbers.Split(' ');

            if (parts.Length != n)
            {
                Console.WriteLine("Ошибка: Количество введенных чисел не совпадает с заявленным.");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (!double.TryParse(parts[i], out numbers[i]))
                {
                    Console.WriteLine($"Ошибка ввода: '{parts[i]}' не является числом. Пожалуйста, введите числа.");
                    return;
                }
            }

            double max = numbers[0];
            double min = numbers[0];

            for (int i = 1; i < n; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            double difference = max - min;

            Console.WriteLine("Максимальное число: " + max);
            Console.WriteLine("Минимальное число: " + min);
            Console.WriteLine("Разница между максимальным и минимальным: " + difference);

            Console.ReadKey();
        }
    }
}