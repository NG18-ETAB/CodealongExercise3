using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3.Inheritance
{
    class Dog : Animal
    {
        public Dog(int age, string name, double weight , bool goodBoy) :
            base(age, name, weight)
        {
            GoodBoy = goodBoy;
        }
        public bool GoodBoy { get; set; }
    }
}
