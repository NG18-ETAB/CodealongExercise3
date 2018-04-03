using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3.Inheritance
{
    public class Horse : Animal
    {
        public double Speed { get; set; }

        public Horse(int age, string name, double weight, double speed): base(age, name, weight)
        {
            Speed = speed;
        }
    }
}
