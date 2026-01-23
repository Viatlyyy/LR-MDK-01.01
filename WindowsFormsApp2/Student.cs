using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Student
    {
        private string name_;
        private int age_;
        private double avgBall_;
        private string number_;
        private string photo_;
        public Student()
        {
            name_ = "Вася Пупкин";
            age_ = 15;
        }

        public string Name
        {
            get { return name_; }
        }
        public Student(string name, int age, double avgBall, string Number, string photo)
        {
            name_ = name;
            age_ = age;
            avgBall_ = avgBall;
            number_ = Number;
            photo_ = photo;
        }
        public int Age
        {
            get { return age_; }
        }
        public double AvgBall
        {
            get { return avgBall_; } 
        }
        public string Number
        {
            get { return number_; }
        }
        public string Photo
        {
            get { return photo_; }
        }
        
    }
}
