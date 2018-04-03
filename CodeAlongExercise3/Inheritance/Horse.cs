using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public class Horse : Animal
    {
        public Horse(string name, double weight, int age, string breed, double speed) : base(name, weight, age)
        {
            Speed = speed;
        }

        public double Speed { get; set; }

        public override string Stats()
        {
            return base.Stats() + $", speed: {Speed}";
        }
    }
}
