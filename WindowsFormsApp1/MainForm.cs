using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FileNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FileNamesListBox.SelectedItem != null)
            {
                PictureArea.Load(FileNamesListBox.SelectedItem.ToString());
                PictureArea.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
            
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD1 = new OpenFileDialog();
            OFD1.Filter = "JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";
            var text = "";
            if (OFD1.ShowDialog() == DialogResult.OK)
            {
                text = OFD1.FileName;
                FileNamesListBox.Items.Add(text);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Вы точно хотите удалить файл из списка?", "Точно?", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                FileNamesListBox.Items.RemoveAt(FileNamesListBox.SelectedIndex);
                PictureArea.Image = null;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD2 = new OpenFileDialog();
            OFD2.Filter = "JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";
            string text = "";
            if (OFD2.ShowDialog() == DialogResult.OK)
            {
                text = OFD2.FileName;
                FileNamesListBox.Items.Add(text);
            }
        }
    }
}
