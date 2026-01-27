using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
   public class Homosapiens
    {
        protected string name_;
        protected int age_;

        public string GetName()
        {
            return name_;
        }

        public Homosapiens (string name, int age)
        {
            name_ = name;
            age_ = age;
        }
        public override string ToString()
        {
            return $"{GetName()}, {age_} лет";
        }
    }
}
