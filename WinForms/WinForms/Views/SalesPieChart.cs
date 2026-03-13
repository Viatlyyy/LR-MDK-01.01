using ClassLibrary;
using ClassLibrary.Presenters;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Views
{
    public class SalesPieChart : LiveCharts.WinForms.PieChart
    {
        private SalesPresenter presenter_;

        public void SetPresenter(SalesPresenter presenter)
        {
            presenter_ = presenter;
        }
        public void UpdateView()
        {
            List<Book> allItems = presenter_.GetAllBooks(); ;
            SeriesCollection seriesData = new SeriesCollection();
            foreach (Book b in allItems)
            {
                seriesData.Add(new PieSeries
                {
                    Title = b.Name,
                    Values = new ChartValues<double> { presenter_.GetProfitPercentByBook(b) },
                    DataLabels = true,
                    
                });
            }
            Series = seriesData;
            
        }
    }
}
