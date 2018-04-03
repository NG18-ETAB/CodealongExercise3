using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public class Worm : Animal
    {
        public Worm(string name, double weight, int age, bool isGummy) : base(name, weight, age)
        {
            IsGummy = isGummy;
        }

        public bool IsGummy { get; set; }

        public override string Stats()
        {
            return base.Stats() + $", candy: {IsGummy}";
        }
    }
}
