using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piaterochka
{
    class ProductSortingStep
    {
        public List<Product> SortProducts(List<Product> products)
        {
            AveragePriceCalculationStep priceCalculator = new AveragePriceCalculationStep();


            for (int i = 0; i < products.Count - 1; i++)
            {
                for (int j = 0; j < products.Count - i - 1; j++)
                {
                    decimal price1 = priceCalculator.CalculateAveragePrice(products[j].PriceHistory);
                    decimal price2 = priceCalculator.CalculateAveragePrice(products[j + 1].PriceHistory);


                    if (price1 < price2)
                    {
                        Product temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }

            return products;
        }
    }
}
