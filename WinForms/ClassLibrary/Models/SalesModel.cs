using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class SalesModel
    {
        private Dictionary<Book, List<Sale>> salesByBooks_ = new Dictionary<Book, List<Sale>>();

        public void AddSales(Book book, List<Sale> sales)
        {
            if (salesByBooks_.ContainsKey(book))
            {
                salesByBooks_[book].AddRange(sales);
            }
            else
            {
                salesByBooks_.Add(book, sales);
            }
        }
        public List<Sale> LoadSalesForBook(string bookName)
        {
            List<Book> allBooks = salesByBooks_.Keys.ToList();
            Book targetBook = allBooks.Find(book => book.Name == bookName);
            if (targetBook != null)
            {
                return salesByBooks_[targetBook];
            }

            return new List<Sale>();
        }
        public bool Load()
        {
            AddSales(new Book { Name = "Война и мир", Price = 1000, Genre = "Роман-Эпопея"},
                new List<Sale>() {
                    new Sale {Time = new System.DateTime(2026, 2, 1), Count = 10 } ,
                    new Sale {Time = new System.DateTime(2026, 2, 2), Count = 20 },
                    new Sale {Time = new System.DateTime(2026, 2, 3), Count = 30 },
                    new Sale {Time = new System.DateTime(2026, 2, 4), Count = 40 },
                    new Sale {Time = new System.DateTime(2026, 2, 5), Count = 50 },
                    new Sale {Time = new System.DateTime(2026, 2, 6), Count = 60 },
                    new Sale {Time = new System.DateTime(2026, 2, 7), Count = 70 },
                    new Sale {Time = new System.DateTime(2026, 2, 8), Count = 55 },
                    new Sale {Time = new System.DateTime(2026, 2, 9), Count = 35 },
                    new Sale {Time = new System.DateTime(2026, 2, 10), Count = 1 },
                });

            AddSales(new Book { Name = "Мертвые души", Price = 1500, Genre = "Поэма" },
                new List<Sale>() {
                    new Sale {Time = new System.DateTime(2026, 2, 1), Count = 15 } ,
                    new Sale {Time = new System.DateTime(2026, 2, 2), Count = 25 },
                    new Sale {Time = new System.DateTime(2026, 2, 3), Count = 31 },
                    new Sale {Time = new System.DateTime(2026, 2, 10), Count = 2 },
                    new Sale {Time = new System.DateTime(2026, 3, 1), Count = 35 },
               });

            return true;
        }
        public List<Book> GetAllBooks()
        {
            return salesByBooks_.Keys.ToList();
        }
        public double GetTotalProfit()
        {
            double result = 0.0;
            foreach (KeyValuePair<Book, List<Sale>> keyValue in salesByBooks_)
            {
                Book book = keyValue.Key;
                result += keyValue.Value.Sum(sale => sale.Count * book.Price);
            }

            return result;
        }
        public Book GetBook(string bookName)
        {
            foreach (KeyValuePair<Book, List<Sale>> keyValue in salesByBooks_)
            {
                Book book = keyValue.Key;
                if (book.Name == bookName)
                {
                    return book;
                }
            }

            return null;
        }
    }
}
