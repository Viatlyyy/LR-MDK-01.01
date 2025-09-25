using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Var_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int array = 2500;

            int[] numbers = new int[array];
            for (int i = 0; i < array; i++)
            {
                numbers[i] = random.Next(-2000, 2001);
            }
            List<int> foundNumbers = new List<int>();
            
            for (int i = 0; i < array; i++)
            {
                int number = numbers[i];
                int lastDigit = Math.Abs(number % 10);
                if (lastDigit == 4)
                {
                    foundNumbers.Add(number);
                }
            }

        }
    }
}
