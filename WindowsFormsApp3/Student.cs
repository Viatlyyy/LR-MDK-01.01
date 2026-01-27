using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Student : Homosapiens
    {
        private int numberTicket_;

        public Student(int numberTicket): base ("Вася Пупкин", 20)
        {
            numberTicket_ = numberTicket;
        }
        public int NumberTicket
        {
            get {return numberTicket_;}
        }
        public override string ToString()
        {
            return base.ToString() + ", номер билета " + numberTicket_;
        }
    }
}
