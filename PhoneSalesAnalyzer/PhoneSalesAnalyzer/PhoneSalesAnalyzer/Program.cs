using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        SalesData salesData = new SalesData();

        SeedSalesData(salesData);

        SalesAnalyzer analyzer = new SalesAnalyzer(salesData);

        List<KeyValuePair<string, double>> sortedProfits = analyzer.GetSortedProfits();

        Console.WriteLine("Результаты анализа продаж");

        if (sortedProfits.Count > 0)
        {
            KeyValuePair<string, double> firstPhone = sortedProfits[0];
            Console.WriteLine($"Самый прибыльный телефон: {firstPhone.Key} (Прибыль: {firstPhone.Value})");
        }

        if (sortedProfits.Count > 1)
        {
            KeyValuePair<string, double> secondPhone = sortedProfits[1];
            Console.WriteLine($"Второй по прибыльности телефон: {secondPhone.Key} (Прибыль: {secondPhone.Value})");
        }
        else if (sortedProfits.Count == 1)
        {
            Console.WriteLine("Найден только один вид телефона.");
        }
        else
        {
            Console.WriteLine("Данные о продажах отсутствуют.");
        }

        Console.WriteLine("Нажмите любую клавишу для завершения");
        Console.ReadKey();
    }

    private static void SeedSalesData(SalesData salesData)
    {
        List<SaleRecord> sampleSales = new List<SaleRecord>();

        sampleSales.Add(new SaleRecord(new DateTime(2023, 10, 26), "Samsung Galaxy S23", 5, 70000, 55000));
        sampleSales.Add(new SaleRecord(new DateTime(2023, 10, 26), "iPhone 15", 3, 95000, 70000));
        sampleSales.Add(new SaleRecord(new DateTime(2023, 10, 27), "Samsung Galaxy S23", 2, 70000, 55000));
        sampleSales.Add(new SaleRecord(new DateTime(2023, 10, 27), "Xiaomi Redmi Note 12", 10, 20000, 15000));
        sampleSales.Add(new SaleRecord(new DateTime(2023, 10, 28), "iPhone 15", 1, 95000, 70000));
        sampleSales.Add(new SaleRecord(new DateTime(2023, 10, 28), "Xiaomi Redmi Note 12", 8, 20000, 15000));
        sampleSales.Add(new SaleRecord(new DateTime(2023, 10, 29), "Samsung Galaxy S23", 3, 70000, 55000));
        sampleSales.Add(new SaleRecord(new DateTime(2023, 10, 29), "OnePlus 11", 4, 65000, 50000));

        foreach (SaleRecord sale in sampleSales)
        {
            salesData.AddSale(sale);
        }
    }
}
