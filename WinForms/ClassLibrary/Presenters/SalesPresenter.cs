using ClassLibrary.Analysis;
using ClassLibrary.Models;
using ClassLibrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Presenters
{
    public class SalesPresenter
    {
        private SalesModel model_ = new SalesModel();

        private List<ISalesView> views_;

        public SalesPresenter(List<ISalesView> views)
        {
            views_ = views;

            model_.Load();
        }

        public void ShowSalesByBook(string bookName)
        {
            List<Sale> sales = model_.LoadSalesForBook(bookName);
            foreach (ISalesView view in views_)
            {
                view.Show(sales);
            }

        }

        public List<Book> GetAllBooks()
         {
            return model_.GetAllBooks();
         }

        public double GetProfitPercentByBook(Book selectedBook)
        {
            double result = ProfitAnalyzer.CalculateProfitPercentByBook(selectedBook.Name, model_);
            return Math.Round(result, 2);
        }
    }
 }

