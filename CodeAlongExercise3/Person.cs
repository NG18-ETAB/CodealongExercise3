using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public class Person
    {
        private int age;
        private string fName, lName;
        private double weight, height;

        public int Age {
            get { return age; }
            set { age = value;}
        }
        public string FName {
            get { return fName; }
            set { fName = value; }
        }
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
    }
}
