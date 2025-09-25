using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_var_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n;
          Console.Write("Введите количество чисел в массиве: ");
          n = Convert.ToInt32(Console.ReadLine());

          int[] numbers = new int[n];

          Console.WriteLine("Введите числа:");
          string input = Console.ReadLine();
          string[] parts = input.Split(' ');

          for (int i = 0; i < n; i++)
          {
              numbers[i] = int.Parse(parts[i]);
          }
            int max = numbers[0];
            int min = numbers[0];

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

        }
    }
}
