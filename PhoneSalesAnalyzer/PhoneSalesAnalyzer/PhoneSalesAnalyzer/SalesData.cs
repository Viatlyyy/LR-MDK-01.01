using System;
using System.Collections.Generic;

public class SalesData
{
    private List<SaleRecord> salesList;

    public SalesData()
    {
        salesList = new List<SaleRecord>();
    }

    public void AddSale(SaleRecord sale)
    {
        if (sale.PhoneModel != null)
        {
            salesList.Add(sale);
        }
    }

    public IEnumerable<SaleRecord> GetAllSales()
    {
        return salesList;
    }

    public void ClearSales()
    {
        salesList.Clear();
    }
}
