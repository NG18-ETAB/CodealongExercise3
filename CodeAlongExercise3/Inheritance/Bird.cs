using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public class Bird : Animal
    {
        public Bird(string name, double weight, int age, string plummage) : base(name, weight, age)
        {
            Plummage = plummage;
        }

        public string Plummage { get; set; }

        public override string Stats()
        {
            return base.Stats() + $", plummage: {Plummage}";
        }
    }
}
