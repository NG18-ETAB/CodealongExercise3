using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public class Hedgehog : Animal
    {
        public Hedgehog(string name, double weight, int age, int numberOfRings) : base(name, weight, age)
        {
            NumberOfRings = numberOfRings;
        }

        public int NumberOfRings { get; set; }

        public override string Stats()
        {
            return base.Stats() + $", have collected {NumberOfRings} rings";
        }
    }
}
