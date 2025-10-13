using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piaterochka
{
    class CategoryRequestStep
    {
        public string RequestCategory()
        {
            Console.WriteLine("Выберите категорию продуктов (Крупы, Фрукты, Овощи):");
            return Console.ReadLine();
        }
    }
}
