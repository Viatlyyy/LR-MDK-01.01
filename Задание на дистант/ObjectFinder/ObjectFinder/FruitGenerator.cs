using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectFinder
{
    public class FruitGenerator
    {
        static Random random = new Random();
        static string[] fruitNames = { "Яблоко", "Банан", "Апельсин", "Виноград", "Клубника", "Арбуз", "Груша", "Манго", "Ананас", "Черника" };

        public static Fruit[] Create100RandomFruits()
        {
            int count = 100;
            Fruit[] fruits = new Fruit[count];

            double minWeight = 10.0;
            double maxWeight = 510.0;
            int minSweetness = 1;
            int maxSweetness = 10;

            for (int i = 0; i < count; i++)
            {
                string name = fruitNames[random.Next(fruitNames.Length)] + " №" + (i + 1);
                double weight = Math.Round(random.NextDouble() * (maxWeight - minWeight) + minWeight, 1);
                int sweetness = random.Next(minSweetness, maxSweetness + 1);

                fruits[i] = new Fruit(name, weight, sweetness);
            }
            return fruits;
        }
    }
}
