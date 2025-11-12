using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectFinder
{
    public class FruitFinder
    {
        public struct CharacteristicInfo
        {
            public Fruit fruit;
            public string characteristicName;
            public double value;
        }

        public static CharacteristicInfo[] FindTop10MaxCharacteristics(Fruit[] fruitArray)
        {
            if (fruitArray == null || fruitArray.Length == 0)
            {
                return new CharacteristicInfo[0];
            }

            int maxResults = Math.Min(10, fruitArray.Length);
            CharacteristicInfo[] top10Result = new CharacteristicInfo[maxResults];
            int top10Count = 0;
            bool[] fruitAlreadyAdded = new bool[fruitArray.Length];

            for (int i = 0; i < maxResults; i++)
            {
                CharacteristicInfo bestInfoForThisIteration = new CharacteristicInfo();
                bestInfoForThisIteration.value = -1;
                int indexOfBestFruitForThisIteration = -1;

                for (int j = 0; j < fruitArray.Length; j++)
                {
                    if (fruitAlreadyAdded[j])
                    {
                        continue;
                    }

                    Fruit currentFruit = fruitArray[j];

                    if (currentFruit.WeightGrams > bestInfoForThisIteration.value)
                    {
                        bestInfoForThisIteration.value = currentFruit.WeightGrams;
                        bestInfoForThisIteration.characteristicName = "Вес";
                        bestInfoForThisIteration.fruit = currentFruit;
                        indexOfBestFruitForThisIteration = j;
                    }

                    if ((double)currentFruit.SweetnessLevel > bestInfoForThisIteration.value)
                    {
                        bestInfoForThisIteration.value = currentFruit.SweetnessLevel;
                        bestInfoForThisIteration.characteristicName = "Сладость";
                        bestInfoForThisIteration.fruit = currentFruit;
                        indexOfBestFruitForThisIteration = j;
                    }
                }

                if (indexOfBestFruitForThisIteration != -1)
                {
                    top10Result[top10Count] = bestInfoForThisIteration;
                    fruitAlreadyAdded[indexOfBestFruitForThisIteration] = true;
                    top10Count++;
                }
                else
                {
                    break;
                }
            }

            CharacteristicInfo[] finalResult = new CharacteristicInfo[top10Count];
            for (int i = 0; i < top10Count; i++)
            {
                finalResult[i] = top10Result[i];
            }

            return finalResult;
        }
    }
}