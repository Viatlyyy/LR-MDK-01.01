using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Analysis
{
    public class ProfitAnalyzer
    {
        
        public static double CalculateProfitPercentByBook(string bookName, SalesModel model)
        {
           
            List<Sale> bookSales = model.LoadSalesForBook(bookName);
            Book targetBook = model.GetBook(bookName);
            if (targetBook == null)
            {
                return 0.0;
            }
            double bookTotal = bookSales.Sum(sale => sale.Count * targetBook.Price);

            
            double total = model.GetTotalProfit();
            if (total == 0.0)
            {
                return 0.0;
            }

            return bookTotal / total * 100.0;
        }
    }
}
    

