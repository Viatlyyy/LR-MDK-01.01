using ClassLibrary;
using ClassLibrary.Presenters;
using ClassLibrary.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace WinForms
{
    public partial class MainForm : Form
    {
        private SalesPresenter presenter_;
        void FillCartesianChart()
        {
            BookList.DataSource = presenter_.GetAllBooks();
            BookList.DisplayMember = "Name";
            if (BookList.Items.Count > 0)
            {
                presenter_.ShowSalesByBook(((Book)BookList.Items[0]).Name);
            }
        }
        public MainForm()
        {
            InitializeComponent();

            presenter_ = new SalesPresenter(new List<ISalesView> { cartesianChart1 });

            FillCartesianChart();
            FillAngular();
            FillSolid();
            PieChart.SetPresenter(presenter_);
            PieChart.UpdateView();
        }
        void FillAngular()
        {
            angular.FromValue = 0;
            angular.ToValue = 100;
            angular.TickStep = 2;
            angular.TicksForeground = System.Windows.Media.Brushes.Black;

            angular.LabelsEffect = null;
        }
        void FillSolid()
        {
            solid.From = 0;
            solid.To = 100;
            solid.LabelFormatter = value => value + "%";
        }
        private void ItemsList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Book selectedItem = ((Book)(BookList.SelectedItem));
            if (selectedItem == null)
            {
                return;
            }

            presenter_.ShowSalesByBook(selectedItem.Name);
            double percent = Math.Round(
            presenter_.GetProfitPercentByBook(selectedItem), 2);
            angular.Value = percent;
            solid.Value = percent;
        }
    }
}
