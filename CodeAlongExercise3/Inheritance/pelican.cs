using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3.Inheritance
{
    public class Pelican : Bird
    {
        public Pelican(int age, string name, double weight, string plummage,double beakVolume) : base(age, name, weight, plummage)
        {
            BeakVolume = BeakVolume;

        }
        public double BeakVolume { get; set; }
    }
}
