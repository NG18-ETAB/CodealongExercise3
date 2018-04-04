using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public class Worm : Animal
    {
        public Worm(int age, string name,
            double weight, bool isGummy) :
            base(age, name, weight)
        {
            IsGummy = isGummy;
        }

        public bool IsGummy { get; set; }
        public override string Stats()
        {
            return base.Stats() + " Is it Gummy?:"+ IsGummy;
        }
    }
}
