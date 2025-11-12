using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectFinder
{
    public class Fruit
    {
        public string Name;
        public double WeightGrams;
        public int SweetnessLevel;

        public Fruit(string name, double weight, int sweetness)
        {
            Name = name;
            WeightGrams = weight;
            SweetnessLevel = sweetness;
        }

        public override string ToString()
        {
            return $"Фрукт: {Name}, Вес: {WeightGrams:F1} г, Сладость: {SweetnessLevel}";
        }
    }
}