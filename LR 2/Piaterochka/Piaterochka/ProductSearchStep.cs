using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piaterochka
{
    class ProductSearchStep
    {
        public List<Product> FindProductsByCategory(string category, List<Product> allProducts)
        {
            List<Product> productsInCategory = new List<Product>();
            foreach (Product product in allProducts)
            {
                if (product.Category == category)
                {
                    productsInCategory.Add(product);
                }
            }
            return productsInCategory;
        }
    }
}
