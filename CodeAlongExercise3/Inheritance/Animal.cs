using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public virtual string Stats()
        {
            string aN = "";
            switch (GetType().Name.ToLower().Substring(0, 1))
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    aN = "n";
                    break;
                default:
                    break;
            }
            return $"Name: {Name}, is a{aN} {GetType().Name}, age: {Age}, Weight: {Weight}";
        }
    }
}
