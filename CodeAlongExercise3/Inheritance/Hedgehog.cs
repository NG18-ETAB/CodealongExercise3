using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public class Hedgehog : Animal              
    {
        public Hedgehog(int age, string name, double weight, int numberOfRings):
            base(age, name, weight)
        {
            NumberOfRings = numberOfRings;
        }
        public int NumberOfRings { get; set; }
    }
}
