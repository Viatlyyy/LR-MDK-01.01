using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piaterochka
{
    class DataFetchingStep
    {
        public List<Product> GetProductData()
        {
            List<Product> products = new List<Product>();


            Product rice = new Product();
            rice.Name = "Рис";
            rice.Category = "Крупы";
            rice.PriceHistory = new List<decimal>() { 55.00m, 57.50m, 60.00m };
            products.Add(rice);

            Product buckwheat = new Product();
            buckwheat.Name = "Гречка";
            buckwheat.Category = "Крупы";
            buckwheat.PriceHistory = new List<decimal>() { 70.00m, 72.50m, 75.00m };
            products.Add(buckwheat);

            Product oatmeal = new Product();
            oatmeal.Name = "Овсяные хлопья";
            oatmeal.Category = "Крупы";
            oatmeal.PriceHistory = new List<decimal>() { 40.00m, 42.00m, 45.00m };
            products.Add(oatmeal);


            Product apples = new Product();
            apples.Name = "Яблоки";
            apples.Category = "Фрукты";
            apples.PriceHistory = new List<decimal>() { 90.00m, 95.00m, 100.00m };
            products.Add(apples);

            Product bananas = new Product();
            bananas.Name = "Бананы";
            bananas.Category = "Фрукты";
            bananas.PriceHistory = new List<decimal>() { 60.00m, 62.00m, 65.00m };
            products.Add(bananas);

            Product oranges = new Product();
            oranges.Name = "Апельсины";
            oranges.Category = "Фрукты";
            oranges.PriceHistory = new List<decimal>() { 85.00m, 90.00m, 92.00m };
            products.Add(oranges);


            Product carrots = new Product();
            carrots.Name = "Морковь";
            carrots.Category = "Овощи";
            carrots.PriceHistory = new List<decimal>() { 35.00m, 37.00m, 40.00m };
            products.Add(carrots);

            Product tomatoes = new Product();
            tomatoes.Name = "Томаты";
            tomatoes.Category = "Овощи";
            tomatoes.PriceHistory = new List<decimal>() { 120.00m, 125.00m, 130.00m };
            products.Add(tomatoes);

            Product potatoes = new Product();
            potatoes.Name = "Картофель";
            potatoes.Category = "Овощи";
            potatoes.PriceHistory = new List<decimal>() { 45.00m, 47.00m, 50.00m };
            products.Add(potatoes);

            return products;
        }
    }
}
