using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public class Horse : Animal
    {
        public Horse(int age, string name,
            double weight, double speed):
            base(age, name, weight)
        {
           Speed = speed;
        }

        public double Speed { get; set; }

        public override string Stats()
        {
            return base.Stats() + " Speed " + Speed;
        }
    }
}
