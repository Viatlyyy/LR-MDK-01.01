using System;

public struct SaleRecord
{
    public DateTime SaleDate;
    public string PhoneModel;
    public int QuantitySold;
    public double PricePerUnit;
    public double CostPerUnit;

    public SaleRecord(DateTime saleDate, string phoneModel, int quantitySold, double pricePerUnit, double costPerUnit)
    {
        SaleDate = saleDate;
        PhoneModel = phoneModel;
        QuantitySold = quantitySold;
        PricePerUnit = pricePerUnit;
        CostPerUnit = costPerUnit;
    }

    public double CalculateProfit()
    {
        if (CostPerUnit > PricePerUnit)
        {
            return 0;
        }
        return (PricePerUnit - CostPerUnit) * QuantitySold;
    }
}

