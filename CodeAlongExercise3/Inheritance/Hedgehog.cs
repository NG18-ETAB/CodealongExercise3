using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    class Hedgehog : Animal
    {
        public Hedgehog(int age, string name, double weight ,int numberOfRings) : 
            base(age, name, weight)
        {
            NumverOfRings = numberOfRings;
        }
        public int NumverOfRings { get; set; }
    }
}
