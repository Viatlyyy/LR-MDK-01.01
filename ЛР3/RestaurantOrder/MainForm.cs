using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrder
{
    public partial class MainForm : Form
    {
        private Dictionary<string, MenuGroup> MenuData;
        public MainForm()
        {
            InitializeComponent();
            LoadInitialData();
        }
        private void InitializeMenuData()
        {
            MenuData = new Dictionary<string, MenuGroup>();

            
            MenuGroup snacks = new MenuGroup();
            snacks.Name = "Закуски";
            snacks.Items.Add(new MenuItem { Name = "Брускетта", Price = 350.00, Ingredients = "Хлеб, томаты, базилик", ImagePath = "C:\\Users\\st53\\Downloads\\1.jpg" });
            snacks.Items.Add(new MenuItem { Name = "Сырная тарелка", Price = 680.50, Ingredients = "Пармезан, дор блю, мед", ImagePath = "C:\\Users\\st53\\Downloads\\1.jpg" });
            MenuData.Add(snacks.Name, snacks);

            
            MenuGroup mains = new MenuGroup();
            mains.Name = "Основные блюда";
            mains.Items.Add(new MenuItem { Name = "Стейк Рибай", Price = 1850.00, Ingredients = "Говядина, розмарин", ImagePath = "C:\\Users\\st53\\Downloads\\1.jpg" });
            mains.Items.Add(new MenuItem { Name = "Паста Карбонара", Price = 790.00, Ingredients = "Спагетти, бекон, сыр", ImagePath = "C:\\Users\\st53\\Downloads\\1.jpg" });
            MenuData.Add(mains.Name, mains);
        }
        private void LoadInitialData()
        {
            InitializeMenuData();

            
            List<string> groupNames = new List<string>(MenuData.Keys);
            lbMenuGroups.DataSource = groupNames;

            
            nudQuantity.Minimum = 1;
            nudQuantity.Value = 1;

            
            toolTipManager.SetToolTip(lbMenuGroups, "Выберите группу блюд меню.");
            toolTipManager.SetToolTip(cbMenuItems, "Выберите заказываемое блюдо.");
            toolTipManager.SetToolTip(nudQuantity, "Укажите желаемое количество.");
            toolTipManager.SetToolTip(btnOrder, "Сформировать итоговый заказ.");

            ClearItemCard();
        }

        private void LoadItemImage(string path)
        {
            
            if (string.IsNullOrEmpty(path))
            {
                pbItemImage.Image = null;
                return;
            }

            
            pbItemImage.Image = System.Drawing.Image.FromFile(path);
            pbItemImage.SizeMode = PictureBoxSizeMode.Zoom; 
        }
        private void lbMenuGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMenuGroups.SelectedItem == null) return;

            string selectedGroupName = lbMenuGroups.SelectedItem.ToString();

            if (MenuData.ContainsKey(selectedGroupName))
            {
                MenuGroup group = MenuData[selectedGroupName];

                
                cbMenuItems.DataSource = group.Items;
                cbMenuItems.DisplayMember = "Name";
                cbMenuItems.SelectedIndex = -1;

                ClearItemCard();
            }
        }

        private void cbMenuItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMenuItems.SelectedItem == null)
            {
                ClearItemCard();
                return;
            }

            MenuItem selectedItem = (MenuItem)cbMenuItems.SelectedItem;

            
            lblItemDetails.Text = selectedItem.GetDescription();

           
            LoadItemImage(selectedItem.ImagePath);

            nudQuantity.Value = 1;


        }
        private void ClearItemCard()
        {
            lblItemDetails.Text = "Выберите блюдо для просмотра деталей.";
            pbItemImage.Image = null;
            nudQuantity.Value = 1;
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (lbMenuGroups.SelectedItem == null || cbMenuItems.SelectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать группу и блюдо.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MenuItem orderedItem = (MenuItem)cbMenuItems.SelectedItem;
            int quantity = (int)nudQuantity.Value;
            string groupName = lbMenuGroups.SelectedItem.ToString();

            
            double totalCost = orderedItem.Price * quantity;

            
            string orderLine =
                "Группа: " + groupName +
                " | Позиция: " + orderedItem.Name +
                " | Кол-во: " + quantity +
                " | Сумма: " + totalCost.ToString("F2") + " руб.\n";

            
            rtbOrderSummary.AppendText(orderLine);

            
            cbMenuItems.SelectedIndex = -1;
            nudQuantity.Value = 1;


        }
    }
  }
    
