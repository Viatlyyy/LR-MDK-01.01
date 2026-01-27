using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MainForm : Form
    {
        private List<Homosapiens> allPeople_ = new List<Homosapiens>();
        public MainForm()
        {
            InitializeComponent();
        }
        public List<string> AllStudentsInfo() 
        {
            List<string> result = new List<string>();
            foreach (Homosapiens people in allPeople_)
            {
                Student st = people as Student;
                if (st != null)
                {
                    result.Add(st.ToString());
                }
            }
            return result;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            allPeople_.Add(new Homosapiens("Владимир Симонов", 50));
            allPeople_.Add(new Homosapiens("Антон Иванов", 30));
            allPeople_.Add(new Student(988));


            foreach (Homosapiens people in allPeople_)
            {
                HomosapiensRichTextBox.AppendText(people.ToString() + "\n");
            }
            StudentInfoRichTextBox.Text = string.Join(",", AllStudentsInfo());
        }
    }
}

