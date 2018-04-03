using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public class Pelican : Bird
    {
        public Pelican(string name, double weight, int age, string plummage, double beakVolume) : base(name, weight, age, plummage)
        {
            BeakVolume = beakVolume;
        }

        public double BeakVolume { get; set; }
    }
}
