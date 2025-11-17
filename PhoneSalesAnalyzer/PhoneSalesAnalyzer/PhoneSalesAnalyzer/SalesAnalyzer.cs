using System;
using System.Collections.Generic;

public class SalesAnalyzer
{
    private SalesData salesDataManager;

    public SalesAnalyzer(SalesData salesDataManager)
    {
        if (salesDataManager == null)
        {
            throw new ArgumentNullException("salesDataManager не может быть null.");
        }
        this.salesDataManager = salesDataManager;
    }

    public List<KeyValuePair<string, double>> GetSortedProfits()
    {
        Dictionary<string, double> totalProfitPerModel = new Dictionary<string, double>();

        foreach (SaleRecord sale in salesDataManager.GetAllSales())
        {
            double currentProfit = sale.CalculateProfit();

            if (totalProfitPerModel.ContainsKey(sale.PhoneModel))
            {
                totalProfitPerModel[sale.PhoneModel] = totalProfitPerModel[sale.PhoneModel] + currentProfit;
            }
            else
            {
                totalProfitPerModel.Add(sale.PhoneModel, currentProfit);
            }
        }

        List<KeyValuePair<string, double>> sortedProfits = new List<KeyValuePair<string, double>>(totalProfitPerModel);

        int n = sortedProfits.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (sortedProfits[j].Value < sortedProfits[j + 1].Value)
                {
                    KeyValuePair<string, double> temp = sortedProfits[j];
                    sortedProfits[j] = sortedProfits[j + 1];
                    sortedProfits[j + 1] = temp;
                }
            }
        }

        return sortedProfits;
    }
}
