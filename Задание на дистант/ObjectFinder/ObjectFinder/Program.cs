using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectFinder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Fruit[] allFruits = FruitGenerator.Create100RandomFruits();

            FruitFinder.CharacteristicInfo[] top10 = FruitFinder.FindTop10MaxCharacteristics(allFruits);

            Console.WriteLine("ТОП 10 фруктов по наибольшим значениям характеристик");
            if (top10.Length == 0)
            {
                Console.WriteLine("Не найдено фруктов.");
            }
            else
            {
                for (int i = 0; i < top10.Length; i++)
                {
                    FruitFinder.CharacteristicInfo info = top10[i];
                    Console.WriteLine($"{info.fruit.ToString()} (по характеристике '{info.characteristicName}' со значением {info.value:F1})");
                }
            }
        }
    }
}
