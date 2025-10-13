using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piaterochka
{
    class Program
    {
        static void Main(string[] args)
        {

            DataFetchingStep dataFetcher = new DataFetchingStep();
            List<Product> products = dataFetcher.GetProductData();


            CategoryRequestStep categoryRequester = new CategoryRequestStep();
            string userCategory = categoryRequester.RequestCategory();


            ProductSearchStep productSearcher = new ProductSearchStep();
            List<Product> productsInCategory = productSearcher.FindProductsByCategory(userCategory, products);


            AveragePriceCalculationStep priceCalculator = new AveragePriceCalculationStep();
            ProductSortingStep productSorter = new ProductSortingStep();

            List<Product> sortedProducts = productSorter.SortProducts(productsInCategory);


            Console.WriteLine("Товары в категории:");
            foreach (Product product in sortedProducts)
            {
                decimal averagePrice = priceCalculator.CalculateAveragePrice(product.PriceHistory);
                Console.WriteLine($"- {product.Name} - {averagePrice} rub.");
            }

            Console.ReadKey();
        }
    }
}
