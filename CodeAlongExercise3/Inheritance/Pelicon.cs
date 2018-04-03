using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    class Pelicon : Bird
    {
        public Pelicon(int age, string name, double weight, string plumage, double beakVolume) : base(age, name, weight, plumage)
        {
            BeakVolume = beakVolume;
        }
        public double BeakVolume { get; set; }
    }
}
