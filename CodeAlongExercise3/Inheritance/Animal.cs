using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    class Animal
    {
        //Constructor
        public Animal(int age, string name, double weight)
        {
            Age = age;
            Name = name;
            Weigth = weight;

        }
        public int Age { get; set; }
        public string Name { get; set; }
        public double Weigth { get; set; }
    }
}
