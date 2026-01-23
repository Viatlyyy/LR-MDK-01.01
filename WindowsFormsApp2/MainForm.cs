using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class MainForm: Form
    {
        private List<Student> allStudent_ = new List<Student>();
        public MainForm()
        {
            InitializeComponent();
    
            allStudent_.Add(new Student("Антон", 18, 4.33, "11", "C:\\Users\\st56\\Downloads\\scale_1200.jpg"));
            allStudent_.Add(new Student("Сергей", 20, 4.67, "52", "C:\\Users\\st56\\Downloads\\3213.jpg"));
            allStudent_.Add(new Student("Петр", 17, 3.67, "28", "C:\\Users\\st56\\Downloads\\123.jpg"));

            StudentNameListBox.DisplayMember = "Name";
            StudentNameListBox.DataSource = allStudent_;

            
        }

        private void StudentNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student s1 = StudentNameListBox.SelectedItem as Student;
            AgeLabel.Text = s1.Age.ToString();
            AvgBallLabel.Text = s1.AvgBall.ToString();
            NumberLabel.Text = s1.Number;
            

            pictureArea.Load(s1.Photo);
            pictureArea.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
