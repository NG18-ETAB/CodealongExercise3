using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    class Worm : Animal
    {
        public bool IsGummy { get; set; }

        public Worm(int age, string name, double weight, bool isGummy) : base(age, name, weight)
        {
            IsGummy = isGummy;
        }
    }
}
